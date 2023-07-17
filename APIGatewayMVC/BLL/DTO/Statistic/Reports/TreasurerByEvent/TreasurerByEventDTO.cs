using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.TreasurerByEvent
{
    public class TreasurerByEventDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public int TransactionId { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TransactionEmail { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public DateTime ToDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public int GitfAid { get; set; }
        public int Refunded { get; set; }
        public int FeesNotPaid { get; set; }
        public int FeePaid { get; set; }
        public int PlatformFeesNotPaid { get; set; }
        public int PlatformFeePaid { get; set; }
    }
}
