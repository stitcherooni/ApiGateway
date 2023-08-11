using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.EmailTracker
{
    public class GetEmailTrackerReportsResponse : PagesInfoDTO
    {
        public IEnumerable<EmailTrackerDTO> Data { get; set; }
        public int TotalEmailsSent { get; set; }
        public int TotalEmailsDelivered { get; set; }
        public int TotalEmailsOpened { get; set; }
    }
}
