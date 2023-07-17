using BLL.DTO.Statistic.Reports.Ticket;

namespace BLL.DTO.Statistic.Searching.Ticket
{
    public class SearchTicketsReportResponse : PagesInfoDTO
    {
        public IEnumerable<TicketDTO> Data { get; set; }
    }
}
