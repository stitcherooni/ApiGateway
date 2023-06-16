using AutoMapper;
using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Exceptions;
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
        private readonly IEmailService _emailService;
        private readonly IRepository<TblSchool> _schoolRepository;
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IRepository<TblCustomerRole> _customerRoleRepository;

        public OnboardingService(IMapper mapper, 
                                 IEmailService emailService, 
                                 IRepository<TblSchool> schoolRepository, 
                                 IRepository<TblCustomer> customerRepository, 
                                 IRepository<TblCustomerRole> customerRoleRepository)
        {
            _mapper = mapper;
            _emailService = emailService;
            _schoolRepository = schoolRepository;
            _customerRepository = customerRepository;
            _customerRoleRepository = customerRoleRepository;
        }

        public async Task<OnboardingEntities> OnboardOrganization(OnboardingFormDataDTO onboardingFormDataDTO, CancellationToken cancellationToken)
        {
            string customerEmail;
            OnboardingEntities onboardingEntities;
            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var schoolDetailsMap = _mapper.Map<TblSchool>(onboardingFormDataDTO.SchoolDetails);
                    schoolDetailsMap.SchoolPtadirectory = onboardingFormDataDTO.SchoolBrandingDetails.Url;
                    schoolDetailsMap.SchoolPrimaryColour = schoolDetailsMap.SchoolLinkColour = onboardingFormDataDTO.SchoolBrandingDetails.PtaBrandingColor;
                    await _schoolRepository.AddAsync(schoolDetailsMap, cancellationToken);

                    CheckRole(onboardingFormDataDTO.AccountDetails.Role);
                    var accountDetailsMap = _mapper.Map<TblCustomer>(onboardingFormDataDTO.AccountDetails);
                    accountDetailsMap.CustomerSchoolId = schoolDetailsMap.SchoolId;
                    await _customerRepository.AddAsync(accountDetailsMap, cancellationToken);

                    var customerRole2 = new TblCustomerRole
                    {
                        CustomerId = accountDetailsMap.CustomerId,
                        RoleId = 2
                    };
                    var customerRole7 = new TblCustomerRole
                    {
                        CustomerId = accountDetailsMap.CustomerId,
                        RoleId = 7
                    };
                    await _customerRoleRepository.AddAsync(customerRole2, cancellationToken);
                    await _customerRoleRepository.AddAsync(customerRole7, cancellationToken);

                    customerEmail = accountDetailsMap.CustomerEmail;

                    transactionScope.Complete();
                    onboardingEntities = new OnboardingEntities()
                    {
                        School = schoolDetailsMap,
                        Customer = accountDetailsMap,
                        CustomerRole2= customerRole2,
                        CustomerRole7 = customerRole7,
                    };
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(RoleException))
                    throw new Exception("Entity can't be added to the database");
                else throw;
            }
            if (customerEmail != null)
            {
                await _emailService.SendEmail(customerEmail, cancellationToken);
            }
            else throw new Exception("Customer doesn't exist");
            return onboardingEntities;
    }

    public async Task<int> GetEntityCountAsync(string key, CancellationToken cancellationToken)
        {
            return await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == key, cancellationToken);
        }

        public async Task<string[]> GenerateUrlsAsync(CheckUrlRequest urlRequest, CancellationToken cancellationToken)
        {
            try
            {
                List<string> urlVariants = new List<string>();

                string nameAcronym = GEtAcronym(urlRequest.PtaName);
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == nameAcronym, cancellationToken) == 0 && nameAcronym.Length >= 3)
                    urlVariants.Add(nameAcronym);


                string newName = urlRequest.PtaName.Replace(" ", string.Empty);
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == newName, cancellationToken) == 0 && newName.Length >= 3)
                    urlVariants.Add(newName);


                string townAcronym = nameAcronym + urlRequest.Town;
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == townAcronym, cancellationToken) == 0 && townAcronym.Length >= 3)
                    urlVariants.Add(townAcronym);


                string newTown = newName + urlRequest.Town;
                if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == newTown, cancellationToken) == 0 && newTown.Length >= 3)
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

        private void CheckRole(string roleName)
        {
            if (!Enum.TryParse<Roles>(roleName, true, out _))
            throw new RoleException($"Role {roleName} doesn't exist");
        }
        #endregion
    }
}