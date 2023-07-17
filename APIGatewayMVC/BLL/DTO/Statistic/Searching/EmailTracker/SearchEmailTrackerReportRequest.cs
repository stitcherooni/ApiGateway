using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Searching.EmailTracker
{
    public class SearchEmailTrackerReportRequest
    {
        public int MessageId { get; set; }
        public DateTime EmailStartDate { get; set; }
        public DateTime EmailEndDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string CustomerEmail { get; set; }

        public string SentBy { get; set; }
    }
}
