namespace BLL.DTO.Statistic.Searching.Sales
{
    public class TotalSoldByDayDTO
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public int QuantityToDate { get; set; }
        public int TotalSales { get; set; }
        public int SalesToDate { get; set; }
        public string Currency { get; set;}
    }
}
