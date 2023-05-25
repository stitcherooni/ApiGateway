using AutoMapper;
using BLL.DTO;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using System.Text.RegularExpressions;
using System.Transactions;

namespace BLL.Services
{
    public class OnboardingService : IOnboardingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OnboardingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task OnboardOrganization(OnboardingFormDataDTO onboardingFormDataDTO)
        {
            using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var schoolDetailsMap = _mapper.Map<TblSchool>(onboardingFormDataDTO.SchoolDetails);
                schoolDetailsMap.SchoolPtadirectory = onboardingFormDataDTO.SchoolBrandingDetails.Url;
                schoolDetailsMap.SchoolPrimaryColour = schoolDetailsMap.SchoolLinkColour = onboardingFormDataDTO.SchoolBrandingDetails.PtaBrandingColor;
                await _unitOfWork.CreateRepository<TblSchool>().AddAsync(schoolDetailsMap);

                var accountDetailsMap = _mapper.Map<TblCustomer>(onboardingFormDataDTO.AccountDetails);
                accountDetailsMap.CustomerSchoolId = schoolDetailsMap.SchoolId;
                await _unitOfWork.CreateRepository<TblCustomer>().AddAsync(accountDetailsMap);

                var customerRoleDTO = new TblCustomerRole
                {
                    CustomerId = accountDetailsMap.CustomerId,
                    RoleId = GetRoleId(onboardingFormDataDTO.AccountDetails.Role)
                };
                await _unitOfWork.CreateRepository<TblCustomerRole>().AddAsync(customerRoleDTO);

                transactionScope.Complete();
            }
        }

        public async Task<int> GetEntityCountAsync(string key)
        {
            return await _unitOfWork.CreateRepository<TblSchool>().CountAsync(x => x.SchoolPtadirectory == key);
        }

        public async Task<string[]> GenerateUrlsAsync(CheckUrlRequest urlRequest)
        {
            List<string> urlVariants = new List<string>();

            string nameAcronym = GEtAcronym(urlRequest.PtaName);
            if (await _unitOfWork.CreateRepository<TblSchool>().CountAsync(x => x.SchoolPtadirectory == nameAcronym) == 0)
                urlVariants.Add(nameAcronym);


            string newName = urlRequest.PtaName.Replace(" ", String.Empty);
            if (await _unitOfWork.CreateRepository<TblSchool>().CountAsync(x => x.SchoolPtadirectory == newName) == 0)
                urlVariants.Add(newName);


            string townAcronym = nameAcronym + urlRequest.Town;
            if (await _unitOfWork.CreateRepository<TblSchool>().CountAsync(x => x.SchoolPtadirectory == townAcronym) == 0)
                urlVariants.Add(townAcronym);


            string newTown = newName + urlRequest.Town;
            if (await _unitOfWork.CreateRepository<TblSchool>().CountAsync(x => x.SchoolPtadirectory == newTown) == 0)
                urlVariants.Add(newTown);

            return urlVariants.ToArray();
        }

        #region Private methods
        private string GEtAcronym(string ptaName)
        {
            var result = Regex.Replace(ptaName, @"\b\w+\b", (x) => x.Value[0].ToString()).Replace(" ", String.Empty);
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