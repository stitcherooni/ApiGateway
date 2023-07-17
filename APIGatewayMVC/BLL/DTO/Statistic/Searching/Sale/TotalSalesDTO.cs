namespace BLL.DTO.Statistic.Searching.Sales
{
    public class TotalSalesDTO
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int TargetQuantity { get; set; }
        public int Difference { get; set; }
        public int Attaintment { get; set; }
        public int TotalSales { get; set; }
        public string Currency { get; set;}
    }
}
