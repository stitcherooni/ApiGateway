using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.Treasurer
{
    public class TreasurerByDateDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Type { get; set; }
        public int PaypalId { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string PaypaEmail { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }
        public int GiftAid { get; set; }
        public int Refunded { get; set; }
        public int Cost { get; set; }
    }
}
