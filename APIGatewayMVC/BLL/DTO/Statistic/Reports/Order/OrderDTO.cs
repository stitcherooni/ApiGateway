using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.Order
{
    public class OrderDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int Orders { get; set; }
        public TotalDTO Value { get; set; }
        public string SchoolName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string TransactionId { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string PayerEmail { get; set; }

        public string PaymentMethod { get; set; }
        public string Type { get; set; }
        public int PlatformFee { get; set; }
        public int Refunded { get; set; }
        public IEnumerable<History> History { get; set; }
    }

    public class History
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public TotalDTO Price { get; set; }
        public TotalDTO LineAmount { get; set; }
        public string Status { get; set; }
    }
}