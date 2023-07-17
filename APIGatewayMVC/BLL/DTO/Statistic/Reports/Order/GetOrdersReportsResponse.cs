namespace BLL.DTO.Statistic.Reports.Order
{
    public class GetOrdersReportsResponse : PagesInfoDTO
    {
        public IEnumerable<OrderDTO> Data { get; set; }
        public TotalDTO TotalSalesAmount { get; set; }
        public TotalDTO TotalProcessingFees { get; set; }
        public TotalDTO TotalPlatformFees { get; set; }

    }
}
