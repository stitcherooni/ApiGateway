using BLL.DTO.Statistic.Reports.Sale;

namespace BLL.DTO.Statistic.Reports.Sales
{
    public class GetSalesReportsResponse
    {
        public SalesDataProps Data { get; set; }
        public int TotalSales { get; set; }
        public int AvgSalesValue { get; set; }
        public int TotalSalesValue { get; set; }
        public int PlatformBookingFees { get; set; }
        public string Currency { get; set; }
    }

    public class GetSalesReport
    {
        public int TotalSales { get; set; }
        public int AvgSalesValue { get; set; }
        public int TotalSalesValue { get; set; }
        public int PlatformBookingFees { get; set; }
        public string Currency { get; set; }
    }
}
