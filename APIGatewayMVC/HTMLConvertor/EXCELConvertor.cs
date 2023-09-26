using ClosedXML.Excel;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace HTMLConvertor
{
    internal static class EXCELConvertor
    {
        public static byte[] Convert(string html)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Sheet1");

            var rows = htmlDoc.DocumentNode.SelectNodes("//table/tr");
            int rowIndex = 1;

            if (rows != null)
            {
                foreach (var row in rows)
                {
                    var cells = row.SelectNodes("td");
                    int columnIndex = 1;

                    if (cells != null)
                    {
                        foreach (var cell in cells)
                        {
                            var cellStyle = ws.Cell(rowIndex, columnIndex).Style;

                            // Extract background color from bgcolor attribute
                            var bgColor = cell.GetAttributeValue("bgcolor", "");
                            if (!string.IsNullOrEmpty(bgColor))
                            {
                                cellStyle.Fill.BackgroundColor = XLColor.FromHtml(bgColor);
                            }

                            // Extract text color from the inline style
                            var pElement = cell.SelectSingleNode("p");
                            if (pElement != null)
                            {
                                var styleAttribute = pElement.GetAttributeValue("style", "");
                                var stylePairs = styleAttribute.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                                foreach (var stylePair in stylePairs)
                                {
                                    var styleParts = stylePair.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                    if (styleParts.Length == 2)
                                    {
                                        var styleName = styleParts[0].Trim();
                                        var styleValue = styleParts[1].Trim();

                                        if (styleName == "color")
                                        {
                                            cellStyle.Font.FontColor = XLColor.FromHtml(styleValue);
                                        }
                                    }
                                }
                            }

                            ws.Cell(rowIndex, columnIndex).Value = cell.InnerText;
                            columnIndex++;
                        }
                    }

                    rowIndex++;
                }
            }
            using (MemoryStream memoryStream = new MemoryStream())
            {
                wb.SaveAs(memoryStream);
                wb.SaveAs("output.xlsx");
                return memoryStream.ToArray();
            }
        }
    }
}
