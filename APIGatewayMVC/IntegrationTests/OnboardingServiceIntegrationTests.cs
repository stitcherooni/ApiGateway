using BLL.DTO.Organisation;
using BLL.Services.Onboarding;
using DAL.Repository.DBRepository;
using Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class OnboardingServiceIntegrationTests
    {
        private readonly IRepository<TblSchool> _schoolRepository;
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IRepository<TblCustomerRole> _customerRoleRepository;
        private readonly IOnboardingService _onboardingService;

        public OnboardingServiceIntegrationTests()
        {
            _customerRepository = new Repository<TblCustomer>(Helper.CreateDbContext());
            _schoolRepository = new Repository<TblSchool>(Helper.CreateDbContext());
            _customerRoleRepository = new Repository<TblCustomerRole>(Helper.CreateDbContext());
            _onboardingService = Helper.CreateOnboardingService();
        }

        [Fact]
        public async Task OnboardOrganisation_ValidData_SavesToDatabaseAndSendsEmail()
        {
            // Arrange
            var onboardingFormDataDTO = await Helper.CreateOnboardingFormDataDTOAsync();

            // Act
            var onboardingEntities = await _onboardingService.OnboardOrganisation(onboardingFormDataDTO, CancellationToken.None);

            // Assert
            await EqualValues(onboardingEntities);
        }

        [Fact]
        public async Task Generate_New_Urls()
        {
            // Arrange
            var urlRequest = await Helper.CreateUrlRequest();

            // Act
            var result = await _onboardingService.GenerateUrlsAsync(urlRequest, CancellationToken.None);

            // Assert
            Assert.Equal(3, result.Count());
            Assert.Contains("epn", result);
            Assert.Contains("exampleptaname", result);
            Assert.Contains("exampleptanametown", result);
        }

        [Fact]
        public async Task Get_Not_Null_Entity_Count()
        {
            // Arrange
            var entitySchool = new TblSchool() { SchoolPtadirectory = await Helper.GenerateUrl(), SchoolPtaname="name" };
            await _schoolRepository.AddAsync(entitySchool, CancellationToken.None);

            // Act
            var result = await _onboardingService.GetEntityCountAsync(entitySchool.SchoolPtadirectory, CancellationToken.None);

            // Assert
            Assert.Equal(1, result);
            await _schoolRepository.DeleteAsync(entitySchool, CancellationToken.None);
        }

        [Fact]
        public async Task Get_Null_Entity_Count()
        {
            // Arrange
            var entitySchool = new TblSchool() { SchoolPtadirectory = await Helper.GenerateUrl() };

            // Act
            var result = await _onboardingService.GetEntityCountAsync(entitySchool.SchoolPtadirectory, CancellationToken.None);

            // Assert
            Assert.Equal(0, result);
        }

        #region Private methods

        private async Task EqualValues(OnboardingEntities onboardingFormDataDTO)
        {
            var actualSchoolRepository = _schoolRepository.FindBy(x => x == onboardingFormDataDTO.School).ToList().FirstOrDefault();
            var actualCustomerRepository = _customerRepository.FindBy(x => x == onboardingFormDataDTO.Customer).ToList().FirstOrDefault();
            var actualCustomerRole = _customerRoleRepository.FindBy(x => x == onboardingFormDataDTO.CustomerRole2).ToList().FirstOrDefault();

            Assert.NotNull(actualSchoolRepository);
            Assert.NotNull(actualCustomerRepository);
            Assert.NotNull(actualCustomerRole);

            await _schoolRepository.DeleteAsync(actualSchoolRepository, CancellationToken.None);
            await _customerRepository.DeleteAsync(actualCustomerRepository, CancellationToken.None);
            await _customerRoleRepository.DeleteAsync(actualCustomerRole, CancellationToken.None);
        }
        #endregion
    }
}