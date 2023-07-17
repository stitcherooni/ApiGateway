namespace BLL.DTO.Statistic.Reports.Dashboard
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public int Value { get; set; }
        public string Currency { get; set; }
    }
}
