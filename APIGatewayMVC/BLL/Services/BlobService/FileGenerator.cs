using ClosedXML.Excel;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace BLL.Services.BlobService
{
    public static class FileGenerator
    {
        public static byte[] CreateCSVFile(IList<IList<string>> data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (StreamWriter streamWriter = new StreamWriter(memoryStream))
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        foreach (string value in data[i])
                        {
                            streamWriter.Write(value + ",");
                        }
                        streamWriter.WriteLine();
                    }
                    streamWriter.Flush();
                }
                return memoryStream.ToArray();
            }
        }

        public static byte[] CreateExcelFile(IList<IList<string>> data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet = workbook.Worksheets.Add("Sheet1");

                    int rowCount = data.Count;
                    int columnCount = 0;

                    foreach (List<string> innerList in data)
                    {
                        if (innerList.Count > columnCount)
                            columnCount = innerList.Count;
                    }

                    for (int row = 0; row < rowCount; row++)
                    {
                        IList<string> rowData = data[row];
                        for (int col = 0; col < columnCount; col++)
                        {
                            if (col < rowData.Count)
                                worksheet.Cell(row + 1, col + 1).Value = rowData[col];
                        }
                    }

                    workbook.SaveAs(memoryStream);
                }

                return memoryStream.ToArray();
            }
        }

        public static byte[] CreatePDFFile(IList<IList<string>> data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdfDocument = new PdfDocument(writer);
                Document document = new Document(pdfDocument);

                string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TrebuchetMS.ttf");
                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                Table table = new Table(data[0].Count);

                foreach (string header in data[0])
                {
                    Cell headerCell = new Cell().Add(new Paragraph(header));
                    headerCell.SetBackgroundColor(new DeviceRgb(45, 65, 84));
                    headerCell.SetFontColor(ColorConstants.WHITE);
                    headerCell.SetFontSize(11);
                    headerCell.SetFont(font);
                    table.AddHeaderCell(headerCell);
                }

                for (int i = 1; i < data.Count; i++)
                {
                    foreach (string value in data[i])
                    {
                        Cell valueCell = new Cell().Add(new Paragraph(value));
                        valueCell.SetFontSize(10);
                        table.AddCell(valueCell);
                    }
                }

                document.Add(table);
                document.Close();
                return memoryStream.ToArray();
            }
        }
    }
}