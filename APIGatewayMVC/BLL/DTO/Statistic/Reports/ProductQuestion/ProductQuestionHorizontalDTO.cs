using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.ProductQuestion
{
    public class ProductQuestionHorizontalDTO
    {
        public int Num { get; set; }
        public int OrderId { get; set; }
        public string BookingName { get; set; }
        public string ClassName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BookedFor { get; set; }
        public string Product { get; set;}
        public int Price { get; set; }
        public int Order { get; set; }
        public DateTime Date { get; set; }
        public string Terms { get; set; }
        public IEnumerable<string> Allergies { get; set; }
        public IEnumerable<Answers> Answers { get; set; }
    }
}
