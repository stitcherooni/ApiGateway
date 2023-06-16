namespace BLL.DTO.Organization
{
    public class AccountDetailsDTO
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string Role { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }

        public bool CustomerApproved { get { return true; } }
        public bool CustomerConfirmed { get { return true; } }
        public bool CustomerMarketingEmails { get { return true; } }
        public bool CustomerPlatformArchiveReminderEmails { get { return true; } }
        public bool CustomerVerified { get { return true; } }
    }
}