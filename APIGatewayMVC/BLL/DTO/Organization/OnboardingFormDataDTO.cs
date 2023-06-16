using Models;

namespace BLL.DTO.Organization
{
    public class OnboardingFormDataDTO
    {
        public SchoolDetailsDTO SchoolDetails { get; set; }
        public SchoolBrandingDetailsDTO SchoolBrandingDetails { get; set; }
        public AccountDetailsDTO AccountDetails { get; set; }
    }

    public class OnboardingEntities
    {
        public TblSchool School { get; set; }
        public TblCustomerRole CustomerRole2 { get; set; }
        public TblCustomerRole CustomerRole7 { get; set; }
        public TblCustomer Customer { get; set; }
    }
}
