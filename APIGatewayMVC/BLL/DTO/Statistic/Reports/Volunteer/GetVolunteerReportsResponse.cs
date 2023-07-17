namespace BLL.DTO.Statistic.Reports.Volunteer
{
    public class GetVolunteerReportsResponse : PagesInfoDTO
    {
        public IEnumerable<VolunteerDTO> Data { get; set; }
    }
}
