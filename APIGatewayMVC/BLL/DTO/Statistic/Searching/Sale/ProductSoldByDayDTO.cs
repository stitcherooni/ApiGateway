using BLL.DTO.Statistic.Reports.Sale;

namespace BLL.DTO.Statistic.Searching.Sales
{
    public class ProductsSoldByDayItem : SoldItem
    {
        public IEnumerable<SoldByDayProduct> Data { get; set; }
        public int TotalPercentage { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalQuantityToDate { get; set; }
        public int TotalSales { get; set; }
        public int TotalToDate { get; set;}
    }

    public class SoldByDayProduct
    {
        public int Num { get; set; }
        public DateTime Date { get; set; }
        public int Percentage { get; set; }
        public int Quantity { get; set; }
        public int QuantityToDate { get; set; }
        public int TotalSales { get; set; }
        public int ToDate { get; set; }
    }
}
