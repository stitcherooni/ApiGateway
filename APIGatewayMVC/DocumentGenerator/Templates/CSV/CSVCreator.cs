using System.Collections.Generic;
using System.Text;

namespace DocumentGenerator.Templates.CSV
{
    internal static  class CSVCreator
    {
        public static byte[] Create(IEnumerable<string> headers, IEnumerable<IEnumerable<string>> tableValues)
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
