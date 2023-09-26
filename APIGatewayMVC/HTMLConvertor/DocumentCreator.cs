using DinkToPdf;
using DinkToPdf.Contracts;
using HTMLConvertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DocumentCreator
{
    public class DocumentCreator
    {
        private PDFConvertor _pdf;

        public DocumentCreator(PDFConvertor pdf) 
        {
        _pdf = pdf;
        }

        public byte[] GenerateDocument()
        { 
        HtmlCreator html= new HtmlCreator();
            var htmlDocument = html.Create("new table", new List<string> { "one", "two", "three" }, new List<List<string>> { new List<string> { "1", "2", "3" }, new List<string> { "4", "5", "6" }, new List<string> { "7", "8", "9" } });

            
            var pdfDocument = _pdf.Convert(htmlDocument);


            File.WriteAllBytes("1.pdf", pdfDocument);

            return pdfDocument;
        }
    }
}
