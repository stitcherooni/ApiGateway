using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Booking
{
    public class GetBookingsReportsResponse
    {
        public IEnumerable<BookingDTO> Data { get; set; }
        public int TotalProductQuantity { get; set; }
    }

    public class GetBookingsProductsReportsResponse
    {
        public IEnumerable<BookingDTO> Data { get; set; }
    }  
}
