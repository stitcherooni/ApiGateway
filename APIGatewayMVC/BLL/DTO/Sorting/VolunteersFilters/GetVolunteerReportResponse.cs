namespace BLL.DTO.Sorting.VolunteersFilters
{
    public class GetVolunteerReportResponse
    {
        public string EventName { get; set; }
        public string EventTime { get; set; }
        public int TotalVolunteers { get; set; }
        public int AvailableVolunteers { get; set; }
    }
}
