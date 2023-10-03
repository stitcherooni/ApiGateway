using System.Collections.Generic;

namespace BLL.DTO
{
    public class ErrorResponseMessage
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string TraceId { get; set; }
        public IDictionary<string, List<string>> Errors { get; set; }
    }
}
