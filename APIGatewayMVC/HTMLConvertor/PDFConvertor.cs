using DinkToPdf;
using DinkToPdf.Contracts;

namespace HTMLConvertor
{
    public class PDFConvertor
    {
        private readonly IConverter _converter;

        public PDFConvertor(IConverter converter)
        {
            _converter = converter;
        }

        public byte[] Convert(string html)
        {
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

            var result = _converter.Convert(document);

            return _converter.Convert(document);
        }
    }
}
