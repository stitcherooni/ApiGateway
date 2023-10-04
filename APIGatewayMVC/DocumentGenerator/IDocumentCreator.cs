using DocumentGenerator.Templates;
using System.Collections.Generic;

namespace DocumentGenerator
{
    public interface IDocumentCreator
    {
        public byte[] GenerateDocument(string title, IList<string> headers, IEnumerable<IEnumerable<string>> tableValues, DocumentType documentType);
    }
}