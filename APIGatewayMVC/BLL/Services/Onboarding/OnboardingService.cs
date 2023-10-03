using AutoMapper;
using BLL.DTO.Organisation;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using DAL.Repository.DBRepository;
using Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.Onboarding
{
    public class OnboardingService : BaseService, IOnboardingService
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

        public async Task<OnboardingEntities> OnboardOrganisation(OnboardingFormDataDTO onboardingFormDataDTO, CancellationToken cancellationToken)
        {
            string customerEmail;
            OnboardingEntities onboardingEntities;

            using (var transactionScope = GetTransactionScope())
            {
                var schoolDetailsMap = _mapper.Map<TblSchool>(onboardingFormDataDTO.SchoolDetails);
                schoolDetailsMap.SchoolPtadirectory = onboardingFormDataDTO.SchoolBrandingDetails.Url;
                schoolDetailsMap.SchoolPrimaryColour = schoolDetailsMap.SchoolLinkColour = onboardingFormDataDTO.SchoolBrandingDetails.PtaBrandingColor;
                await _schoolRepository.AddAsync(schoolDetailsMap, cancellationToken);

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
                    CustomerRole2 = customerRole2,
                    CustomerRole7 = customerRole7,
                };
            }
            await _emailService.SendEmail(customerEmail, cancellationToken);

            return onboardingEntities;
        }

        public async Task<int> GetEntityCountAsync(string key, CancellationToken cancellationToken)
        {
            return await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == key, cancellationToken);
        }

        public async Task<IEnumerable<string>> GenerateUrlsAsync(CheckUrlRequest urlRequest, CancellationToken cancellationToken)
        {
            var urlVariants = new List<string>();

            string nameAcronym = LengthCheck(GEtAcronym(urlRequest.PtaName).ToLower());
            if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == nameAcronym, cancellationToken) == 0 && nameAcronym.Length >= 3)
                urlVariants.Add(nameAcronym);

            string newName = LengthCheck(urlRequest.PtaName.Replace(" ", string.Empty).ToLower());
            if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == newName, cancellationToken) == 0 && newName.Length >= 3)
            {
                if (!urlVariants.Contains(newName))
                    urlVariants.Add(newName);
            }

            string townAcronym = LengthCheck(newName + urlRequest.Town.Replace(" ", string.Empty).ToLower());
            if (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == townAcronym, cancellationToken) == 0 && townAcronym.Length >= 3)
            {
                if (!urlVariants.Contains(townAcronym))
                    urlVariants.Add(townAcronym);
            }
            return urlVariants.ToArray();
        }

        public async Task<bool> IsUrlFree(string url, CancellationToken cancellationToken)
        {
            return await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == url, cancellationToken) == 0;
        }

        #region Private methods
        private string GEtAcronym(string ptaName)
        {
            var result = Regex.Replace(ptaName, @"\b\w+\b", (x) => x.Value[0].ToString()).Replace(" ", string.Empty);
            return result;
        }

        private string LengthCheck(string text)
        {
            if (text.Length >= 50)
                return text.Substring(0, 50);
            else return text;
        }
        #endregion
    }

}