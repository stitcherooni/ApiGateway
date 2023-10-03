using System.Collections.Generic;

namespace DocumentGenerator.Templates.CSV
{
    public interface ICSVCreator
    {
        public byte[] Create(IEnumerable<string> headers, IEnumerable<IEnumerable<string>> tableValues);
    }
}