using AutoMapper;
using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using DAL.Repository.DBRepository;
using Models;
using Moq;
using System.Linq.Expressions;
using Xunit.Sdk;

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
        public void GetEntityCount_WithValidKey_ReturnsCorrectCount()
        {
            // Arrange
            var entities = new List<TblSchool>
        {
            new TblSchool { SchoolPtadirectory = "key" },
            new TblSchool { SchoolPtadirectory = "key" },
            new TblSchool { SchoolPtadirectory = "otherKey" },
        };

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
             .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate) =>
                 {
                     return entities.Count(predicate.Compile());
                 });

            // Act
            var result = _onboardingService.GetEntityCountAsync("key");

            // Assert
            Assert.Equal(2, result.Result);
        }

        [Fact]
        public async Task OnboardOrganization_Should_AddSchoolDetails_And_AccountDetails_With_Role_Administrator()
        {
            // Arrange
            var onboardingFormDataDTO = SetupOnboardingFormDataDTO("Administrator");

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer() { CustomerEmail="someEmail"};
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            _schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult)).Returns(Task.CompletedTask);
            _customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult)).Returns(Task.CompletedTask);
            _customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>())).Returns(Task.CompletedTask);

            // Act
            await _onboardingService.OnboardOrganization(onboardingFormDataDTO);

            // Assert
            _mapperMock.Verify(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>()), Times.Once);
            _mapperMock.Verify(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>()), Times.Once);
            _schoolRepositoryMock.Verify(repo => repo.AddAsync(schoolMappingResult), Times.Once);
            _customerRepositoryMock.Verify(repo => repo.AddAsync(customerMappingResult), Times.Once);
            _customerRoleRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<TblCustomerRole>()), Times.Once);
            _customerRoleRepositoryMock.Verify(x => x.AddAsync(It.Is<TblCustomerRole>(role => role.RoleId == 2)), Times.Once);
        }

        [Fact]
        public async Task OnboardOrganization_Should_AddSchoolDetails_And_AccountDetails_With_Role_Parent()
        {
            // Arrange
            var onboardingFormDataDTO = SetupOnboardingFormDataDTO("Parent");

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer() { CustomerEmail = "someEmail" };
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            _schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult)).Returns(Task.CompletedTask);
            _customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult)).Returns(Task.CompletedTask);
            _customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>())).Returns(Task.CompletedTask);

            // Act
            await _onboardingService.OnboardOrganization(onboardingFormDataDTO);

            // Assert
            _mapperMock.Verify(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>()), Times.Once);
            _mapperMock.Verify(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>()), Times.Once);
            _schoolRepositoryMock.Verify(repo => repo.AddAsync(schoolMappingResult), Times.Once);
            _customerRepositoryMock.Verify(repo => repo.AddAsync(customerMappingResult), Times.Once);
            _customerRoleRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<TblCustomerRole>()), Times.Once);
            _customerRoleRepositoryMock.Verify(x => x.AddAsync(It.Is<TblCustomerRole>(role => role.RoleId == 7)), Times.Once);
        }

        [Fact]
        public async Task OnboardOrganization_Should_Throw_Exception_When_Cant_AddEntity()
        {
            // Arrange
            var errorMessage = "Entity can't be added to the database";

            // Act
            var exception = await Record.ExceptionAsync(async () =>
                await _onboardingService.OnboardOrganization(null));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<Exception>(exception);
            Assert.Equal(exception.Message, errorMessage);
        }

        [Fact]
        public async Task OnboardOrganization_Should_Throw_Exception()
        {
            // Arrange
            var onboardingFormDataDTO = SetupOnboardingFormDataDTO("InvalidRole");

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer();
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            _schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult)).Returns(Task.CompletedTask);
            _customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult)).Returns(Task.CompletedTask);
            _customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>())).Returns(Task.CompletedTask);

            // Act and Assert
            await Assert.ThrowsAsync<Exception>(async () => await _onboardingService.OnboardOrganization(onboardingFormDataDTO));
            _schoolRepositoryMock.Verify(repo => repo.AddAsync(schoolMappingResult), Times.Once);
            _customerRepositoryMock.Verify(repo => repo.AddAsync(customerMappingResult), Times.Once);
            _customerRoleRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<TblCustomerRole>()), Times.Never);
        }

        [Fact]
        public async Task OnboardOrganization_CustomerIsNull_ThrowsException()
        {
            // Arrange
            var errorMessage = "Customer doesn't exist";

            var onboardingFormDataDTO = SetupOnboardingFormDataDTO("Parent"); 

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer();
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            _schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult)).Returns(Task.CompletedTask);
            _customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult)).Returns(Task.CompletedTask);
            _customerRepositoryMock.Setup(repo => repo.FindAsync(It.IsAny<int>()));
            _customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>())).Returns(Task.CompletedTask);

            // Act
            var exception = await Record.ExceptionAsync(async () =>
                await _onboardingService.OnboardOrganization(onboardingFormDataDTO));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<Exception>(exception);
            Assert.Equal(exception.Message, errorMessage);
        }

        [Fact]
        public void GenerateUrls_UniqueAcronym_Returns_List_of_NewUrls()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA Name",
                Town = "Town"
            };

            var schools = new List<TblSchool>();

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
             .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate) =>
             {
                 return schools.Count(predicate.Compile());
             });

            // Act
            var result = _onboardingService.GenerateUrlsAsync(urlRequest);

            // Assert
            Assert.Equal(4, result.Result.Count());
            Assert.Contains("EPN", result.Result);
            Assert.Contains("ExamplePTAName", result.Result);
            Assert.Contains("EPNTown", result.Result);
            Assert.Contains("ExamplePTANameTown", result.Result);
        }

        [Fact]
        public void GenerateUrls_Should_Throw_Exception()
        {
            // Arrange
            var errorMessage = "Can't generate Url";

            // Act
            var exception = Record.ExceptionAsync(async () =>await _onboardingService.GenerateUrlsAsync(new CheckUrlRequest()));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<Exception>(exception.Result);
            Assert.Equal(exception.Result.Message, errorMessage);
        }

        [Fact]
        public void GenerateUrls_UniqueAcronym_Doesnt_Include_3sumbols_values()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA",
                Town = "Town"
            };

            var schools = new List<TblSchool>();

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
                                 .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate)
                                    => schools.Count(predicate.Compile()));

            // Act
            var result = _onboardingService.GenerateUrlsAsync(urlRequest);

            // Assert
            Assert.Equal(3, result.Result.Count());
            Assert.DoesNotContain("EP", result.Result);
            Assert.Contains("ExamplePTA", result.Result);
            Assert.Contains("EPTown", result.Result);
            Assert.Contains("ExamplePTATown", result.Result);
        }

        [Fact]
        public void GenerateUrls_ExistingUrls_ReturnsOnlyUniqueVariants()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA Name",
                Town = "Town"
            };

            var school1 = new TblSchool() { SchoolPtadirectory = "EPN" };
            var school2 = new TblSchool() { SchoolPtadirectory = "ExamplePTAName" };
            var school3 = new TblSchool() { SchoolPtadirectory = "EPNTown" };

            var schools = new List<TblSchool>() { school1, school2, school3 };

            _schoolRepositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
                .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate) =>
                {
                    return schools.Count(predicate.Compile());
                });

            // Act
            var result = _onboardingService.GenerateUrlsAsync(urlRequest);

            // Assert
            Assert.Single(result.Result);
            Assert.DoesNotContain("EPN", result.Result);
            Assert.DoesNotContain("ExamplePTAName", result.Result);
            Assert.DoesNotContain("EPNTown", result.Result);
            Assert.Contains("ExamplePTANameTown", result.Result);
        }

        private OnboardingFormDataDTO SetupOnboardingFormDataDTO(string role)
        {
            return new OnboardingFormDataDTO()

            {
                SchoolDetails = new SchoolDetailsDTO(),
                AccountDetails = new AccountDetailsDTO { Role = role},
                SchoolBrandingDetails = new SchoolBrandingDetailsDTO()
            };
        }
    }
}