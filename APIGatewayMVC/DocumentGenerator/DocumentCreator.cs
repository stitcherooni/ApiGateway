using DocumentGenerator.Templates;
using DocumentGenerator.Templates.CSV;
using DocumentGenerator.Templates.EXCEL;
using DocumentGenerator.Templates.PDF;
using System;
using System.Collections.Generic;

namespace DocumentGenerator
{
    {
        private readonly ICSVCreator _csvCreator;
        private readonly IEXCELCreator _excelCreator;
        private readonly IPDFConvertor _pdfConvertor;

        public DocumentCreator(ICSVCreator csvCreator, IEXCELCreator exelCreator, IPDFConvertor pdfConvertor)
        { 
            _csvCreator = csvCreator;
            _excelCreator = exelCreator;
            _pdfConvertor = pdfConvertor;
        }
      
        public byte[] GenerateDocument(string title, IList<string> headers, IList<IList<string>> tableValues, DocumentType documentType)
        {
            switch (documentType)
            {
                case (DocumentType.Pdf):
                    {
                        
                        return _pdfConvertor.Create(title, headers, tableValues);
                    }
                case (DocumentType.Excel):
                    {
                        return _excelCreator.Create(title, headers, tableValues);
                    }
                case (DocumentType.Csv):
                    {
                        return _csvCreator.Create(headers, tableValues);
                    }

                default:
                    {
                        throw new Exception($"Type {documentType} doesn't exist");
                    }
            }
        }

        public byte[] TestCreation(string html)
        {
            return _pdfConvertor.CreateFromHtml(html);

        }

    }
}
