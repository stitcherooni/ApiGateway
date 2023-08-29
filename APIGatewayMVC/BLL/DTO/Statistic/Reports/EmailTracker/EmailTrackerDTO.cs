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
        public string Status { get; set; }
        public string SendByEmail { get; set; }
        public object EmailEvent { get; set; }
        public int CustomerId { get; set; }
    }

    public class DroppedBounced
    {
        public string Code { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
    }

    public class OpenedClicked
    {
        public string Ip { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string UserAgent { get; set; }
        public string DeviceType { get; set; }
        public string ClientType { get; set; }
        public string ClientName { get; set; }
        public string ClientOs { get; set; }   
    }
}
