using AutoMapper;
using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using DAL.Repository.DBRepository;
using Models;
using System.Text.RegularExpressions;
using System.Transactions;

namespace BLL.Services.Onboarding
{
    public class OnboardingService : IOnboardingService
    {
        private readonly IMapper _mapper;
        private readonly IEmailService _emailsender;
        private readonly IRepository<TblSchool> _schoolRepository;
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IRepository<TblCustomerRole> _customerRoleRepository;

        public OnboardingService(IMapper mapper, 
                                 IEmailService emailsender, 
                                 IRepository<TblSchool> schoolRepository, 
                                 IRepository<TblCustomer> customerRepository, 
                                 IRepository<TblCustomerRole> customerRoleRepository)
        {
            _mapper = mapper;
            _emailsender = emailsender;
            _schoolRepository = schoolRepository;
            _customerRepository = customerRepository;
            _customerRoleRepository = customerRoleRepository;
        }

        public async Task OnboardOrganization(OnboardingFormDataDTO onboardingFormDataDTO)
        {
            string customerEmail;
            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var schoolDetailsMap = _mapper.Map<TblSchool>(onboardingFormDataDTO.SchoolDetails);
                    schoolDetailsMap.SchoolPtadirectory = onboardingFormDataDTO.SchoolBrandingDetails.Url;
                    schoolDetailsMap.SchoolPrimaryColour = schoolDetailsMap.SchoolLinkColour = onboardingFormDataDTO.SchoolBrandingDetails.PtaBrandingColor;
                    await _schoolRepository.AddAsync(schoolDetailsMap);

                    var accountDetailsMap = _mapper.Map<TblCustomer>(onboardingFormDataDTO.AccountDetails);
                    accountDetailsMap.CustomerSchoolId = schoolDetailsMap.SchoolId;
                    await _customerRepository.AddAsync(accountDetailsMap);

                    var customerRole = new TblCustomerRole
                    {
                        CustomerId = accountDetailsMap.CustomerId,
                        RoleId = GetRoleId(onboardingFormDataDTO.AccountDetails.Role)
                    };
                    await _customerRoleRepository.AddAsync(customerRole);

                    customerEmail = accountDetailsMap.CustomerEmail;

                    transactionScope.Complete();
                }
            }
            catch (Exception)
            {
                throw new Exception("Entity can't be added to the database");
            }
            if (customerEmail != null)
            {
                await _emailsender.SendEmail(customerEmail);
            }
            else throw new Exception("Customer doesn't exist");
        }

        public async Task<int> GetEntityCountAsync(string key)
        {
            return await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == key);
        }

        public async Task<string[]> GenerateUrlsAsync(CheckUrlRequest urlRequest)
        {
            try
            {
                List<string> urlVariants = new List<string>();

                string nameAcronym = GEtAcronym(urlRequest.PtaName);
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == nameAcronym) == 0 && nameAcronym.Length >= 3)
                    urlVariants.Add(nameAcronym);


                string newName = urlRequest.PtaName.Replace(" ", string.Empty);
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == newName) == 0 && newName.Length >= 3)
                    urlVariants.Add(newName);


                string townAcronym = nameAcronym + urlRequest.Town;
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == townAcronym) == 0 && townAcronym.Length >= 3)
                    urlVariants.Add(townAcronym);


                string newTown = newName + urlRequest.Town;
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == newTown) == 0 && newTown.Length >= 3)
                    urlVariants.Add(newTown);

                return urlVariants.ToArray();
            }
            catch { throw new Exception("Can't generate Url"); }
        }

        #region Private methods

        private string GEtAcronym(string ptaName)
        {
            var result = Regex.Replace(ptaName, @"\b\w+\b", (x) => x.Value[0].ToString()).Replace(" ", string.Empty);
            return result;
        }

        private int GetRoleId(string roleName)
        {
            if (roleName == "Administrator")
                return 2;
            if (roleName == "Parent")
                return 7;
            throw new Exception("Role doesn't exist");
        }
        #endregion
    }
}