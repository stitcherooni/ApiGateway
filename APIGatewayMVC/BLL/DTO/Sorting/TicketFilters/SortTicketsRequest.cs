namespace BLL.DTO.Sorting.TicketFilters
{
    public class SortTicketsRequest
    {
        public IEnumerable<int> EventIds { get; set; }
        public string Filter { get; set; }
    }
}
