using System.Collections.Generic;

namespace BLL.DTO.Blobs
{
    public class GetFileRequest
    {
        public IEnumerable<int> Ids { get; set; }
        public IEnumerable<string> Columns { get; set; }
        public IEnumerable<IDictionary<string, string>> Ordering { get; set; }
    }
}
