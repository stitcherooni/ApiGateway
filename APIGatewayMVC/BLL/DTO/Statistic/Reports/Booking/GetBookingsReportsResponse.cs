namespace BLL.DTO.Statistic.Reports.Booking
{
    public class GetBookingsReportsResponse : PagesInfoDTO
    {
        public IEnumerable<BookingDTO> Data { get; set; }
    }

    public class GetBookingsProductsReportsResponse
    {
        public IEnumerable<BookingDTO> Data { get; set; }
    }  
}
