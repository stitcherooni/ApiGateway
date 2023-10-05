using System.Collections.Generic;

namespace DocumentGenerator.Templates.PDF
{
    public interface IPDFConvertor
    {
        public byte[] Create(string title, IEnumerable<string> headers, IEnumerable<IEnumerable<string>> tableValues);
        public byte[] CreateFromHtml(string html);
    }
}