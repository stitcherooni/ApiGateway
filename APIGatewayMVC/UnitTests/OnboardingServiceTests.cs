using AutoMapper;
using BLL.DTO.Organisation;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using DAL.Repository.DBRepository;
using Models;
using Moq;
using System.Linq.Expressions;

namespace OnboardingServiceTests
{
    public class OnboardingServiceTests
    {
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IEmailService> _emailsenderMock;
        private readonly Mock<IRepository<TblSchool>> _schoolRepositoryMock;
        private readonly Mock<IRepository<TblCustomer>> _customerRepositoryMock;
        private readonly Mock<IRepository<TblCustomerRole>> _customerRoleRepositoryMock;

        private readonly OnboardingService _onboardingService;

        public OnboardingServiceTests()
        {
            _mapperMock = new Mock<IMapper>();
            _emailsenderMock = new Mock<IEmailService>();
            _schoolRepositoryMock = new Mock<IRepository<TblSchool>>();
            _customerRepositoryMock = new Mock<IRepository<TblCustomer>>();
            _customerRoleRepositoryMock = new Mock<IRepository<TblCustomerRole>>();

            _onboardingService = new OnboardingService(_mapperMock.Object,
                                                       _emailsenderMock.Object,
                                                       _schoolRepositoryMock.Object,
                                                       _customerRepositoryMock.Object,
                                                       _customerRoleRepositoryMock.Object);
        }

        [Fact]
        public async Task GetEntityCount_WithValidKey_ReturnsCorrectCountAsync()
        {
            // Arrange
            var entities = new List<TblSchool>
        {
            new TblSchool { SchoolPtadirectory = "key" },
            new TblSchool { SchoolPtadirectory = "key" },
            new TblSchool { SchoolPtadirectory = "otherKey" },
        };

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>(), It.IsAny<CancellationToken>()))
             .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate, CancellationToken cancellationToken) =>
             {
                 return entities.Count(predicate.Compile());
             });

            // Act
            var result = await _onboardingService.GetEntityCountAsync("key", CancellationToken.None);

            // Assert
            Assert.IsType<int>(result);
            Assert.Equal(2, result);
        }

        [Fact]
        public async Task OnboardOrganisation_Should_AddSchoolDetails_And_AccountDetails_With_Valid_Role()
        {
            // Arrange
            var onboardingFormDataDTO = SetupOnboardingFormDataDTO("Chair");

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer() { CustomerEmail = "someEmail" };
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            _schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult, It.IsAny<CancellationToken>())).Returns(Task.FromResult(schoolMappingResult));
            _customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult, It.IsAny<CancellationToken>())).Returns(Task.FromResult(customerMappingResult));
            _customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>(), It.IsAny<CancellationToken>())).Returns(Task.FromResult(It.IsAny<TblCustomerRole>()));

            // Act
            await _onboardingService.OnboardOrganisation(onboardingFormDataDTO, CancellationToken.None);

            // Assert
            _mapperMock.Verify(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>()), Times.Once);
            _mapperMock.Verify(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>()), Times.Once);
            _schoolRepositoryMock.Verify(repo => repo.AddAsync(schoolMappingResult, It.IsAny<CancellationToken>()), Times.Once);
            _customerRepositoryMock.Verify(repo => repo.AddAsync(customerMappingResult, It.IsAny<CancellationToken>()), Times.Once);
            _customerRoleRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<TblCustomerRole>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
            _customerRoleRepositoryMock.Verify(x => x.AddAsync(It.Is<TblCustomerRole>(role => role.RoleId == 2), It.IsAny<CancellationToken>()), Times.Once);
            _customerRoleRepositoryMock.Verify(x => x.AddAsync(It.Is<TblCustomerRole>(role => role.RoleId == 7), It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task GenerateUrls_UniqueAcronym_Returns_List_of_NewUrlsAsync()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA Name",
                Town = "Town"
            };

            var schools = new List<TblSchool>();

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>(), It.IsAny<CancellationToken>()))
             .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate, CancellationToken cancellationToken) =>
             {
                 return schools.Count(predicate.Compile());
             });

            // Act
            var result = await _onboardingService.GenerateUrlsAsync(urlRequest, CancellationToken.None);

            // Assert
            Assert.Equal(3, result.Count());
            Assert.Contains("epn", result);
            Assert.Contains("exampleptaname", result);
            Assert.Contains("exampleptanametown", result);
        }

        [Fact]
        public async Task GenerateUrls_UniqueAcronym_Doesnt_Include_3sumbols_valuesAsync()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA",
                Town = "Town"
            };

            var schools = new List<TblSchool>();

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>(), It.IsAny<CancellationToken>()))
                                 .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate, CancellationToken cancellation)
                                    => schools.Count(predicate.Compile()));

            // Act
            var result = await _onboardingService.GenerateUrlsAsync(urlRequest, CancellationToken.None);

            // Assert
            Assert.Equal(2, result.Count());
            Assert.DoesNotContain("ep", result);
            Assert.Contains("examplepta", result);
            Assert.Contains("exampleptatown", result);
        }

        [Fact]
        public async Task GenerateUrls_ExistingUrls_ReturnsOnlyUniqueVariantsAsync()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA Name",
                Town = "Town"
            };

            var school1 = new TblSchool() { SchoolPtadirectory = "epn" };
            var school2 = new TblSchool() { SchoolPtadirectory = "exampleptaname" };
            var school3 = new TblSchool() { SchoolPtadirectory = "epntown" };

            var schools = new List<TblSchool>() { school1, school2, school3 };

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate, CancellationToken cancellationToken) =>
                {
                    return schools.Count(predicate.Compile());
                });

            // Act
            var result = await _onboardingService.GenerateUrlsAsync(urlRequest, CancellationToken.None);

            // Assert
            Assert.Single(result);
            Assert.DoesNotContain("EPN", result);
            Assert.DoesNotContain("ExamplePTAName", result);
            Assert.DoesNotContain("EPNTown", result);
            Assert.Contains("exampleptanametown", result);
        }

        [Fact]
        public async Task CheckUrl_Should_ReturnFalse_When_UrlExistsInRepository()
        {
            // Arrange
            string url = "https://example.com";

            _schoolRepositoryMock.Setup(repo => repo.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>(), It.IsAny<CancellationToken>())).ReturnsAsync(1);

            // Act
            bool result = await _onboardingService.IsUrlFree(url, CancellationToken.None);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task CheckUrl_Should_ReturnTrue_When_UrlDoesNotExistInRepository()
        {
            // Arrange
            string url = "https://example.com";

            _schoolRepositoryMock.Setup(repo => repo.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>(), It.IsAny<CancellationToken>())).ReturnsAsync(0);

            // Act
            bool result = await _onboardingService.IsUrlFree(url, CancellationToken.None);

            // Assert
            Assert.True(result);
        }

        private OnboardingFormDataDTO SetupOnboardingFormDataDTO(string role)
        {
            return new OnboardingFormDataDTO()

            {
                SchoolDetails = new SchoolDetailsDTO(),
                AccountDetails = new AccountDetailsDTO { Role = role },
                SchoolBrandingDetails = new SchoolBrandingDetailsDTO()
            };
        }
    }
}