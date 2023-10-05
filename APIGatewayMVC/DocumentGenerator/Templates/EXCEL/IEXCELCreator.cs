using System.Collections.Generic;

namespace DocumentGenerator.Templates.EXCEL
{
    public interface IEXCELCreator
    {
        public byte[] Create(string title, IList<string> headers, IList<IList<string>> tableValues);
    }
}