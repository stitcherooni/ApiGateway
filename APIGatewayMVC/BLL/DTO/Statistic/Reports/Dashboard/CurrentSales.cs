namespace BLL.DTO.Statistic.Reports.Dashboard
{
    public class CurrentSales
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public int QuantitySold { get; set; }
        public int QuantityLeft { get; set; }
        public int Sales { get; set;}
        public string Currency { get; set;}

    }
}
