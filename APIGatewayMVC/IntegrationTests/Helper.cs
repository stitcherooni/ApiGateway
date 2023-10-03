using AutoMapper;
using BLL.DTO.Organisation;
using BLL.DTO.UrlAsync;
using BLL.Mapping;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using DAL;
using DAL.Repository.DBRepository;
using DAL.Repository.EmailSender;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Models;
using Moq;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTests
{
    public static class Helper
    {
        public static async Task<CheckUrlRequest> CreateUrlRequest()
        {
            return new CheckUrlRequest()
            {
                Url = await GenerateUrl(),
                PtaName = "Example PTA Name",
                Town = "Town"
            };
        }

        public static IOnboardingService CreateOnboardingService()
        {
            var _dbContext = CreateDbContext();
            var _schoolRepository = new Repository<TblSchool>(_dbContext);
            var _customerRepository = new Repository<TblCustomer>(_dbContext);
            var _customerRoleRepository = new Repository<TblCustomerRole>(_dbContext);
            return new OnboardingService(
                                                            CreateMapper().Object,
                                                            CreateEmailService(),
                                                            _schoolRepository,
                                                            _customerRepository,
                                                            _customerRoleRepository);
        }

        public static IEmailService CreateEmailService()
        {
            var configuration = GetConfiguration();

            var emailSettings = configuration.GetSection("EmailSettings").Get<EmailSettings>();
            var serviceCollection = new ServiceCollection();

            serviceCollection.Configure<EmailSettings>(options => configuration.GetSection("EmailSettings").Bind(options));

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var optionsMonitor = serviceProvider.GetService<IOptionsMonitor<EmailSettings>>();

            var emailSender = new MailGunEmailSender(optionsMonitor);

            var dbContext = CreateDbContext();
            var customerRepository = new Repository<TblCustomer>(dbContext);
            var messageRepository = new Repository<TblMessage>(dbContext);
            var emailRepository = new Repository<TblEmail>(dbContext);
            var schoolRepository = new Repository<TblSchool>(dbContext);

            return new EmailService(emailSender, customerRepository, messageRepository, emailRepository, schoolRepository);
        }

        public static PtaeventContext CreateDbContext()
        {
            var configuration = GetConfiguration();
            var useInMemoryDatabase = configuration.GetValue<bool>("UseInMemoryDatabase");

            if (useInMemoryDatabase)
            {
                var options = new DbContextOptionsBuilder<PtaeventContext>()
                    .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                    .Options;

                var context = new PtaeventContext(options);
                context.Database.EnsureCreated();
                return context;
            }
            else
            {
                var connectionString = configuration.GetSection("MariaDbServer").Value;

                var options = new DbContextOptionsBuilder<PtaeventContext>()
                    .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                    .Options;

                var context = new PtaeventContext(options);
                context.Database.EnsureCreated();

                return context;
            }
        }

        public static async Task<string> GenerateUrl()
        {
            var _dbContext = CreateDbContext();
            Random rnd = new Random();
            int num = rnd.Next();
            var _schoolRepository = new Repository<TblSchool>(_dbContext);
            while (await _schoolRepository.CountAsync(x => x.SchoolPtadirectory == num.ToString(), CancellationToken.None) != 0)
            {
                num = rnd.Next();
            }
            return num.ToString();
        }

        public static async Task<string> GenerateEmail()
        {
            var _dbContext = CreateDbContext();
            Random rnd = new Random();
            int num = rnd.Next();
            var _customerRepository = new Repository<TblCustomer>(_dbContext);
            while (await _customerRepository.CountAsync(x => x.CustomerEmail == num.ToString() + "@mail.com", CancellationToken.None) != 0)
            {
                num = rnd.Next();
            }
            return num.ToString() + "@mail.com";
        }

        public static async Task<OnboardingFormDataDTO> CreateOnboardingFormDataDTOAsync()
        {
            string url = await GenerateUrl();
            string email = await GenerateEmail();
            return new OnboardingFormDataDTO
            {
                SchoolBrandingDetails = new SchoolBrandingDetailsDTO()
                {
                    Url = url,
                    PtaBrandingColor = "string"
                },
                AccountDetails = new AccountDetailsDTO()
                {
                    CustomerFirstName = "string",
                    CustomerLastName = "string",
                    Role = "Chair",
                    CustomerEmail = email,
                    CustomerPassword = "string"
                },
                SchoolDetails = new SchoolDetailsDTO()
                {
                    SchoolPtaname = "string",
                    SchoolName = "string",
                    SchoolAddress1 = "string",
                    SchoolAddress2 = "string",
                    SchoolTown = "string",
                    SchoolCounty = "string",
                    SchoolPostCode = "string",
                    PlanTypeId = 1
                },
            };
        }

        private static Mock<IMapper> CreateMapper()
        {
            Mock<IMapper> _mapperMock = new Mock<IMapper>();

            _mapperMock.Setup(mapper => mapper.Map<TblSchool>(It.IsAny<SchoolDetailsDTO>())).Returns(new TblSchool() { SchoolPtaname = "string" });
            _mapperMock.Setup(mapper => mapper.Map<TblCustomer>(It.IsAny<AccountDetailsDTO>())).Returns(new TblCustomer() 
            {
                CustomerEmail="string",
                CustomerFirstName="string", 
                CustomerLastName= "string", 
                CustomerPassword= "string",
                CustomerApproved=true,
                CustomerConfirmed=true,
                CustomerMarketingEmails = true,
                CustomerPlatformArchiveReminderEmails = true,
                CustomerVerified = true
            });

            return _mapperMock;
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json")
                                    .Build();
            var emailSettings = new EmailSettings();
            configuration.GetSection("EmailSettings").Bind(emailSettings);
            return configuration;
        }
    }
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomOptions(this IServiceCollection serviceCollection, Action<EmailSettings> emailSettings)
        {
            serviceCollection.Configure(emailSettings);
            return serviceCollection;
        }
    }
}
