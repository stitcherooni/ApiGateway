using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.Volunteer
{
    public class VolunteerDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string VolunteerName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public bool DbsChecked { get; set; }
        public bool FirstAider { get; set; }
        public DateTime Date { get; set; }
        public string Contact { get; set; }
    }
}
