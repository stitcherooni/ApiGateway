using BLL.DTO.Statistic.Reports.ChildOnlyBooking;

namespace BLL.DTO.Statistic.Searching.OnlyBookings
{
    public class ChildOnlyBookingReportResponse:PagesInfoDTO
    {
        public IEnumerable<ChildOnlyBookingDTO> Data { get; set; }
    }
}
