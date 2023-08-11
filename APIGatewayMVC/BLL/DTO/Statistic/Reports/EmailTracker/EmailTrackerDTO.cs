using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.EmailTracker
{
    public class EmailTrackerDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string To { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string MessageTitle { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public int MessageId { get; set; }
        public string SentBy { get; set; }
        public DateTime DateSent { get; set;}
        public bool Delivered { get; set; }
        public DateTime? DeliveredDate { get; set;}
        public bool Opened { get; set; }
        public DateTime? OpenedDate { get; set;}
        public string Location { get; set;}
        public string Ip { get; set; }
        public string Type { get; set; }
    }
}
