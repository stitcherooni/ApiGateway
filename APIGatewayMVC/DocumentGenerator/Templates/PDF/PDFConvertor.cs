using DinkToPdf;
using DocumentGenerator.Templates.HTML;
using System.Collections.Generic;

namespace DocumentGenerator.Templates.PDF
{
    public class PDFConvertor: IPDFConvertor
    {
        private readonly IHtmlCreator _htmlCreator;
        public PDFConvertor(IHtmlCreator htmlCreator) 
            {
                _htmlCreator = htmlCreator;
            }
        public  byte[] Create(string title, IEnumerable<string> headers, IEnumerable<IEnumerable<string>> tableValues)
        {
            var html = _htmlCreator.Create(title, headers, tableValues);
            var converter = new SynchronizedConverter(new PdfTools());

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 },
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = html
            };

            var document = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var result = converter.Convert(document);

            return converter.Convert(document);
        }
    }
}
