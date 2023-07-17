namespace BLL.DTO.UrlAsync
{
    public class CheckUrlRequest
    {
        [UrlValidation(ErrorMessage = "Invalid URL format. Only symbols 'a-z', '0-9', and '-' are allowed.")]
        public string Url { get; set; }
        [UrlValidation(ErrorMessage = "Invalid PtaName format. Only symbols 'a-z', '0-9', and '-' are allowed.")]
        public string PtaName { get; set; }
        [UrlValidation(ErrorMessage = "Invalid Town format. Only symbols 'a-z', '0-9', and '-' are allowed.")]
        public string Town { get; set; }
    }
}
