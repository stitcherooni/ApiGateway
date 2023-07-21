using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.UrlAsync
{
    public class CheckUrlRequest
    {
        public string Url { get; set; }

        public string PtaName { get; set; }

        public string Town { get; set; }
    }
}
