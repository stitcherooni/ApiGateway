using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.Dashboard
{
    public class MonthlyOrder
    {
        [Required(ErrorMessage = "The OrderId is required")]
        public int OrderId { get; set; }
        public string Month { get; set; }
        public int Orders { get; set; }
        public int Sales { get; set; }
        [Required(ErrorMessage = "The Currency is required")]
        public string Currency { get; set; }
    }
}
