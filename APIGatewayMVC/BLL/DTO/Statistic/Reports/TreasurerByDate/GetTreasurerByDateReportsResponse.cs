namespace BLL.DTO.Statistic.Reports.Treasurer
{
    public class GetTreasurerByDateReportsResponse : PagesInfoDTO
    {
        public IEnumerable<TreasurerByDateDTO> Data { get; set; }
        public int TotalSales { get; set; }
        public int Profit { get; set; }
        public double ProcessingFeeNotPaid { get; set; }
        public double PlatformFeesNotPaid { get; set; }
    }
}
