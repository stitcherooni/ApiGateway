using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Collections.Generic;
using System.IO;

namespace DocumentGenerator.Templates.EXCEL
{
    public class EXCELCreator: IEXCELCreator
    {
        public  byte[] Create(string title, IList<string> headers, IList<IList<string>> tableValues)
        {
            // Create a new workbook
            IWorkbook workbook = new HSSFWorkbook();
            ISheet worksheet = workbook.CreateSheet("Sheet1");

            // Create a cell style for the title (merged cells)
            ICellStyle titleStyle = workbook.CreateCellStyle();
            titleStyle.Alignment = HorizontalAlignment.Center;
            titleStyle.VerticalAlignment = VerticalAlignment.Center;
            IFont titleFont = workbook.CreateFont();
            titleFont.FontName = "Calibri";
            titleFont.FontHeightInPoints = 11;
            titleStyle.SetFont(titleFont);

            // Create a row for the title and merge cells
            IRow titleRow = worksheet.CreateRow(0);
            ICell titleCell = titleRow.CreateCell(0);
            titleCell.SetCellValue(title);
            titleCell.CellStyle = titleStyle;
            worksheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, headers.Count - 1));

            // Create a row for headers and make them bold
            IRow headerRow = worksheet.CreateRow(1);
            ICellStyle headerStyle = workbook.CreateCellStyle();
            IFont headerFont = workbook.CreateFont();
            headerFont.Boldweight = (short)FontBoldWeight.Bold;
            headerFont.FontName = "Calibri";
            headerFont.FontHeightInPoints = 11;
            headerStyle.SetFont(headerFont);
            for (int i = 0; i < headers.Count; i++)
            {
                ICell headerCell = headerRow.CreateCell(i);
                headerCell.SetCellValue(headers[i]);
                headerCell.CellStyle = headerStyle;
            }

            ICellStyle dataStyle = workbook.CreateCellStyle();
            IFont dataFont = workbook.CreateFont();
            dataFont.FontName = "Calibri";
            dataFont.FontHeightInPoints = 11;
            dataStyle.SetFont(dataFont);

            // Add table values starting from the third row
            for (int rowIndex = 0; rowIndex < tableValues.Count; rowIndex++)
            {
                IRow dataRow = worksheet.CreateRow(rowIndex + 2);
                IList<string> rowData = tableValues[rowIndex];
                for (int colIndex = 0; colIndex < rowData.Count; colIndex++)
                {
                    ICell dataCell = dataRow.CreateCell(colIndex);
                    dataCell.SetCellValue(rowData[colIndex]);
                }
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                workbook.Write(memoryStream);
                return memoryStream.ToArray();
            }
        }

    }
}


