namespace BLL.DTO.Statistic.Searching.Sales
{
    public class ProductSoldByDayDTO
    {
        public DateTime Date { get; set; }
        public int Percentage { get; set; }
        public int Quantity { get; set; }
        public int QuantityToDate { get; set; }
        public int TotalSales { get; set; }
        public int ToDate { get; set;}
        public string Currency { get; set; }
    }
}
