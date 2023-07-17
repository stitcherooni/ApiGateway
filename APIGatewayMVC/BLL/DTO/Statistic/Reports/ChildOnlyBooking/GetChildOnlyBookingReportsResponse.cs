namespace BLL.DTO.Statistic.Reports.ChildOnlyBooking
{
    public class GetChildOnlyBookingReportsResponse : PagesInfoDTO
    {
        public IEnumerable<ChildOnlyBookingDTO> Data { get; set; }
    }
}