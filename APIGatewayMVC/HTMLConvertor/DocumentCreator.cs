using HTMLConvertor;

namespace DocumentGenerator
{
    public static class DocumentCreator
    {
        public static byte[] GenerateDocument(string title, List<string> headers, List<List<string>> tableValues, DocumentType documentType)
        {
            var html = HtmlCreator.Create("new table", new List<string> { "one", "two", "three" }, new List<List<string>> { new List<string> { "1", "2", "3" }, new List<string> { "4", "5", "6" }, new List<string> { "7", "8", "9" } });

            switch (documentType)
            {
                case (DocumentType.Pdf):
                    {
                        return PDFConvertor.Convert(html);
                    }
                case (DocumentType.Excel):
                    {
                        return EXCELConvertor.Convert(html);
                    }
                case (DocumentType.Csv):
                    {
                        return null;
                    }

                default:
                    {
                        throw new Exception($"Type {documentType} doesn't exist");
                    }
            }
        }

    }
}
