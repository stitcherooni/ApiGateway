using BLL.DTO.Statistic.Reports.Ticket;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.Ticket
{
    public class SearchTicketsReportResponse
    {
        public IEnumerable<TicketDTO> Data { get; set; }
    }
}
