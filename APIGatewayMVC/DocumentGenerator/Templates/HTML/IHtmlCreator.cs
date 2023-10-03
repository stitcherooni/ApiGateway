using System.Collections.Generic;

namespace DocumentGenerator.Templates.HTML
{
    public interface IHtmlCreator
    {
        public string Create(string title, IEnumerable<string> headers, IEnumerable<IEnumerable<string>> tableValues);
    }
}