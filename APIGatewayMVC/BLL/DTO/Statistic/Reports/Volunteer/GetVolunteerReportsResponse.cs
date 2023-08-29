using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Volunteer
{
    public class GetVolunteerReportsResponse
    {
        public IEnumerable<VolunteerDTO> Data { get; set; }
    }
}
