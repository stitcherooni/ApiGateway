using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Reports.Organisation
{
    public class OrganisationDataResponse
    {
        public string Logo { get; set; }


        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string Facebook { get; set; }
        public Location Location { get; set; }
        public int RegistrationNo { get; set; }
    }

    public class Location
    {
        public string OrganisationName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
    }
}
