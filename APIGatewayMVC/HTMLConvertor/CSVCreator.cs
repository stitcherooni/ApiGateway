using System.Text;

namespace DocumentGenerator
{
    internal class CSVCreator
    {
        public static byte[] GenerateCsv(List<string> headers, List<List<string>> tableValues)
        {
            StringBuilder csvContent = new StringBuilder();

            csvContent.AppendLine(string.Join(",", headers));

            foreach (var row in tableValues)
            {
                csvContent.AppendLine(string.Join(",", row));
            }
            byte[] csvBytes = Encoding.UTF8.GetBytes(csvContent.ToString());

            return csvBytes;
        }
    }
}
