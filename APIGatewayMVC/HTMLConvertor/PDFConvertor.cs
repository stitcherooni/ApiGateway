using DinkToPdf;

namespace HTMLConvertor
{
    internal static class PDFConvertor
    {
        public static byte[] Convert(string html)
        {
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
