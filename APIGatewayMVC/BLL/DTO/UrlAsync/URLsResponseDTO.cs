namespace BLL.DTO.UrlAsync
{
    public class URLsResponseDTO
    {
        public IEnumerable<string> Urls { get; set; }
        public bool IsValid { get; set; }
    }
}
