using DocumentGenerator.Templates;
using DocumentGenerator.Templates.CSV;
using DocumentGenerator.Templates.EXCEL;
using DocumentGenerator.Templates.PDF;
using System;
using System.Collections.Generic;

namespace DocumentGenerator
{
    public class DocumentCreator: IDocumentCreator
    {
        public byte[] GenerateDocument(string title, IList<string> headers, IList<IList<string>> tableValues, DocumentType documentType)
        {
            switch (documentType)
            {
                case (DocumentType.Pdf):
                    {
                        
                        return PDFConvertor.Create(title, headers, tableValues);
                    }
                case (DocumentType.Excel):
                    {
                        return EXCELCreator.Create(title, headers, tableValues);
                    }
                case (DocumentType.Csv):
                    {
                        return CSVCreator.Create(headers, tableValues);
                    }

                default:
                    {
                        throw new Exception($"Type {documentType} doesn't exist");
                    }
            }
        }

    }
}
