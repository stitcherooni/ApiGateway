using AutoMapper;
using BLL.DTO;
using BLL.Services;
using DAL.Repository;
using DAL.UnitOfWork;
using Models;
using Moq;
using System.Linq.Expressions;

namespace OnboardingServiceTests
{
    public class OnboardingServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly OnboardingService _onboardingService;

        public OnboardingServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _onboardingService = new OnboardingService(_unitOfWorkMock.Object, _mapperMock.Object);
        }
        [Fact]
        public void GetEntityCount_WithValidKey_ReturnsCorrectCount()
        {
            // Arrange
            var repositoryMock = new Mock<IRepository<TblSchool>>();
            var entities = new List<TblSchool>
        {
            new TblSchool { SchoolPtadirectory = "key" },
            new TblSchool { SchoolPtadirectory = "key" },
            new TblSchool { SchoolPtadirectory = "otherKey" },
        };

            repositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
             .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate) =>
                 {
                     return entities.Count(predicate.Compile());
                 });

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblSchool>())
                .Returns(repositoryMock.Object);

            // Act
            var result = _onboardingService.GetEntityCountAsync("key");

            // Assert
            Assert.Equal(2, result.Result);
        }

        [Fact]
        public async Task OnboardOrganization_Should_AddSchoolDetails_And_AccountDetails()
        {
            // Arrange
            var schoolRepositoryMock = new Mock<IRepository<TblSchool>>();
            var customerRepositoryMock = new Mock<IRepository<TblCustomer>>();
            var customerRoleRepositoryMock = new Mock<IRepository<TblCustomerRole>>();

            var onboardingFormDataDTO = new OnboardingFormDataDTO
            {
                SchoolDetails = new SchoolDetailsDTO(),
                AccountDetails = new AccountDetailsDTO { Role = "Administrator" },
                SchoolBrandingDetails = new SchoolBrandingDetailsDTO()
            };

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer();
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            // Setup unitOfWorkMock
            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblSchool>()).Returns(schoolRepositoryMock.Object);
            schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult)).Returns(Task.CompletedTask);

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblCustomer>()).Returns(customerRepositoryMock.Object);
            customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult)).Returns(Task.CompletedTask);

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblCustomerRole>()).Returns(customerRoleRepositoryMock.Object);
            customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>())).Returns(Task.CompletedTask);

            // Act
            await _onboardingService.OnboardOrganization(onboardingFormDataDTO);

            // Assert
            schoolRepositoryMock.Verify(repo => repo.AddAsync(schoolMappingResult), Times.Once);
            customerRepositoryMock.Verify(repo => repo.AddAsync(customerMappingResult), Times.Once);
            customerRoleRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<TblCustomerRole>()), Times.Once);
        }

        [Fact]
        public async Task OnboardOrganization_Should_Throw_Exception()
        {
            // Arrange
            var schoolRepositoryMock = new Mock<IRepository<TblSchool>>();
            var customerRepositoryMock = new Mock<IRepository<TblCustomer>>();
            var customerRoleRepositoryMock = new Mock<IRepository<TblCustomerRole>>();

            var onboardingFormDataDTO = new OnboardingFormDataDTO()
            {
                SchoolDetails = new SchoolDetailsDTO(),
                AccountDetails = new AccountDetailsDTO { Role = "InvalidRole" },
                SchoolBrandingDetails = new SchoolBrandingDetailsDTO()
            };

            // Setup mapper
            var schoolMappingResult = new TblSchool();
            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(schoolMappingResult);

            var customerMappingResult = new TblCustomer();
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(customerMappingResult);

            // Setup unitOfWorkMock
            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblSchool>()).Returns(schoolRepositoryMock.Object);
            schoolRepositoryMock.Setup(repo => repo.AddAsync(schoolMappingResult)).Returns(Task.CompletedTask);

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblCustomer>()).Returns(customerRepositoryMock.Object);
            customerRepositoryMock.Setup(repo => repo.AddAsync(customerMappingResult)).Returns(Task.CompletedTask);

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblCustomerRole>()).Returns(customerRoleRepositoryMock.Object);
            customerRoleRepositoryMock.Setup(repo => repo.AddAsync(It.IsAny<TblCustomerRole>())).Returns(Task.CompletedTask);

            // Act and Assert
            await Assert.ThrowsAsync<Exception>(async () => await _onboardingService.OnboardOrganization(onboardingFormDataDTO));
            schoolRepositoryMock.Verify(repo => repo.AddAsync(schoolMappingResult), Times.Once);
            customerRepositoryMock.Verify(repo => repo.AddAsync(customerMappingResult), Times.Once);
            customerRoleRepositoryMock.Verify(repo => repo.AddAsync(It.IsAny<TblCustomerRole>()), Times.Never);
        }

        [Fact]
        public void GenerateUrls_UniqueAcronym_Returns_List_of_NewUrls()
        {
            // Arrange
            var urlRequest = new CheckUrlRequest
            {
                PtaName = "Example PTA",
                Town = "Town"
            };

            var schools = new List<TblSchool>();

            var repositoryMock = new Mock<IRepository<TblSchool>>();
            repositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
             .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate) =>
             {
                 return schools.Count(predicate.Compile());
             });

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblSchool>())
                .Returns(repositoryMock.Object);

            // Act
            var result = _onboardingService.GenerateUrlsAsync(urlRequest);

            // Assert
            Assert.Equal(4, result.Result.Count());
            Assert.Contains("EP", result.Result);
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
                PtaName = "Example PTA",
                Town = "Town"
            };

            var school1 = new TblSchool() { SchoolPtadirectory = "EP" };
            var school2 = new TblSchool() { SchoolPtadirectory = "ExamplePTA" };
            var school3 = new TblSchool() { SchoolPtadirectory = "EPTown" };

            var schools = new List<TblSchool>() { school1, school2, school3 };

            var repositoryMock = new Mock<IRepository<TblSchool>>();
            repositoryMock.Setup(r => r.CountAsync(It.IsAny<Expression<Func<TblSchool, bool>>>()))
                .ReturnsAsync((Expression<Func<TblSchool, bool>> predicate) =>
                {
                    return schools.Count(predicate.Compile());
                });

            _unitOfWorkMock.Setup(uow => uow.CreateRepository<TblSchool>())
                .Returns(repositoryMock.Object);

            // Act
            var result = _onboardingService.GenerateUrlsAsync(urlRequest);

            // Assert
            Assert.Single(result.Result);
            Assert.DoesNotContain("EP", result.Result);
            Assert.DoesNotContain("ExamplePTA", result.Result);
            Assert.DoesNotContain("EPTown", result.Result);
            Assert.Contains("ExamplePTATown", result.Result);
        }
    }
}


