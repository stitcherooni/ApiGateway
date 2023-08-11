using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Searching.Order
{
    public class SearchOrdersRequest
    {
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        public int PaypalTransactionId { get; set; }
        public DateTime OrderStartDate { get; set;}
        public DateTime OrderEndDate { get; set;}
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Type { get; set; }
    }
}
