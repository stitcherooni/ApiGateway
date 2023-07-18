using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.UrlAsync
{
    public class CheckUrlRequest
    {
        [StringLength(50, ErrorMessage = "The Url value cannot exceed 50 characters.")]
        [UrlValidation(ErrorMessage = "Invalid URL format. Only symbols 'a-z', '0-9', and '-' are allowed.")]
        public string Url { get; set; }


        [StringLength(50, ErrorMessage = "The PtaName value cannot exceed 50 characters.")]
        [UrlValidation(ErrorMessage = "Invalid PtaName format. Only symbols 'a-z', '0-9', ' ', and '-' are allowed.")]
        public string PtaName { get; set; }


        [StringLength(50, ErrorMessage = "The Town value cannot exceed 50 characters.")]
        [UrlValidation(ErrorMessage = "Invalid Town format. Only symbols 'a-z', '0-9', ' ', and '-' are allowed.")]
        public string Town { get; set; }
    }
}
