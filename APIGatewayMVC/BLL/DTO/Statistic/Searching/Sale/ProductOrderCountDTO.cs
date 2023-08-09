using BLL.DTO.Statistic.Reports.Sale;

namespace BLL.DTO.Statistic.Searching.Sales
{
    public class ProductOrderCount: SoldItem
    {
        public IEnumerable<ProductOrderCountItem> Data { get; set; }
        public int TotalPercentage { get; set; }
        public int TotalOrder { get; set; }
        public int TotalProductCount { get; set; }
    }

    public class ProductOrderCountItem
    {
        public int Percentage { get; set; }
        public int NoOfOrder { get; set; }
        public int ProductCount { get; set; }
    }
}
