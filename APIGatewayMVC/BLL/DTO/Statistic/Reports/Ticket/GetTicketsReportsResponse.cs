using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Ticket
{
    public class GetTicketsReportsResponse : PagesInfoDTO
    {
        public IEnumerable<TicketDTO> Data { get; set; }
        public string Qr { get; set; }
    }
}
