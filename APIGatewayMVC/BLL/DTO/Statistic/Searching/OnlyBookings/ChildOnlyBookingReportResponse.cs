using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.OnlyBookings
{
    public class ChildOnlyBookingReportResponse:PagesInfoDTO
    {
        public IEnumerable<ChildOnlyBookingDTO> Data { get; set; }
    }
}
