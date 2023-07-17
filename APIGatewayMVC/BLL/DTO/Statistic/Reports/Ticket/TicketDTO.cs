namespace BLL.DTO.Statistic.Reports.Ticket
{
    public class TicketDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public int TicketNumber { get; set; }
        public string Contact { get; set; }
        public IEnumerable<string> Allergies { get; set; }
    }
}
