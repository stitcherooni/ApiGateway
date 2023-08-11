using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Searching.Customer
{
    public class SearchCustomersRequest
    {
        public DateTime StartRegDate { get; set; }
        public DateTime EndRegDate { get; set; }
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string PostCode { get; set; }
        public string CustomerApproved { get; set; }
        public string CustomerNewsletter { get; set; }
        public string CustomerMarketingEmail { get; set; }
        public string RegisteredOnClassList { get; set; }
        public string GuestCustomer { get; set; }
    }
}
