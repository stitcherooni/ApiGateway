using BLL.DTO.Statistic.Searching.Sales;

namespace BLL.DTO.Statistic.Reports.Sale
{
    public class SaleDTO
    {
        public int TotalSales { get; set; }
        public int AvgSalesValue { get; set; }
        public int TotalSalesValue { get; set; }
        public int PlatformBookingFees { get; set; }
        public DataDTO Data { get; set; }
    }

    public class DataDTO
    {
        public TotalSales TotalSales { get; set; }
        public TotalSoldByDayDTO TotalSoldByDay { get; set; }
        public IDictionary<string, ProductSoldByDayDTO> ProductsSoldByDay { get; set; }
        public IDictionary<string, ProductsSoldBySchoolDTO> ProductsSoldBySchool { get; set; }
        public IDictionary<string, ProductOrderCountDTO> ProductOrderCount { get; set; }
    }
    public class TotalSales
    {
        public IDictionary<string, int> ProductPercentage { get; set; }
        public TotalSalesDTO TotalSalesDTO { get; set; }
    }
}
