namespace BLL.DTO.Statistic.Searching.TreasurerByDate
{
    public class SearchTreasurerByDateRequest
    {
        public DateTime OrderStartDate { get; set; }
        public DateTime OrderEndDate { get; set; }
        public string PaymentMethod { get; set; }
    }
}
