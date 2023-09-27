using HTMLConvertor;

namespace DocumentGenerator
{
    public static class DocumentCreator
    {
        public static byte[] GenerateDocument(string title, List<string> headers, List<List<string>> tableValues, DocumentType documentType)
        {
            switch (documentType)
            {
                case (DocumentType.Pdf):
                    {
                        var html = HtmlCreator.Create(title, headers, tableValues);
                        return PDFConvertor.Convert(html);
                    }
                case (DocumentType.Excel):
                    {
                        return EXCELConvertor.Create(title, headers, tableValues);
                    }
                case (DocumentType.Csv):
                    {
                        return CSVCreator.GenerateCsv(headers, tableValues);
                    }

                default:
                    {
                        throw new Exception($"Type {documentType} doesn't exist");
                    }
            }
        }

    }
}
