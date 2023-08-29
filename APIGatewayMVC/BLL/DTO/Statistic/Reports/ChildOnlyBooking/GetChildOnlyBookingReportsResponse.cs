using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.ChildOnlyBooking
{
    public class GetChildOnlyBookingReportsResponse
    {
        public IEnumerable<ChildOnlyBookingDTO> Data { get; set; }
        public int SoldQuantity { get; set; }
    }
}