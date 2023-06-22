using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Organization
{
    public class AccountDetailsDTO
    {
        private string _role;

        [Required(ErrorMessage = "The Customer First Name is required")]
        public string CustomerFirstName { get; set; }

        [Required(ErrorMessage = "The Customer Last Name is required")]
        public string CustomerLastName { get; set; }

        public string Role
        {
            get { return _role; }
            set
            {
                if (!Enum.GetNames(typeof(Roles)).Contains(value))
                {
                    throw new ArgumentException("Invalid Role value.");
                }

                _role = value;
            }
        }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string CustomerPassword { get; set; }

        public bool CustomerApproved { get { return true; } }
        public bool CustomerConfirmed { get { return true; } }
        public bool CustomerMarketingEmails { get { return true; } }
        public bool CustomerPlatformArchiveReminderEmails { get { return true; } }
        public bool CustomerVerified { get { return true; } }
    }
}