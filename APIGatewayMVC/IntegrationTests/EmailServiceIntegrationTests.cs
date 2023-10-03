using BLL.Services.EmailService;
using DAL.Repository.DBRepository;
using Models;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class EmailServiceIntegrationTests
    {
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IEmailService _emailService;

        public EmailServiceIntegrationTests()
        {
            _customerRepository = new Repository<TblCustomer>(Helper.CreateDbContext());
            _emailService = Helper.CreateEmailService();
        }

        [Fact]
        public async Task EmailService_Should_Return_OkResult()
        {
            // Arrange
            var email = await Helper.GenerateEmail();
            var entity = await _customerRepository.AddAsync(new TblCustomer()
            {
                CustomerFirstName="FirstName",
                CustomerLastName="LastName",
                CustomerPassword="password",
                CustomerEmail = email,
                CustomerApproved = true,
                CustomerConfirmed = true,
                CustomerMarketingEmails = true,
                CustomerPlatformArchiveReminderEmails = true,
                CustomerVerified = true
            }, CancellationToken.None);

            // Act
            var result = await _emailService.SendEmail(email, CancellationToken.None);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.OK, result.StatusCode);
            await _customerRepository.DeleteAsync(entity, CancellationToken.None);
        }

        [Fact]
        public async Task EmailService_Should_Return_Exception_If_Email_Does_Not_Exist()
        {
            // Arrange
            var email = await Helper.GenerateEmail();
            var errorMessage = $"User with email {email} doesn't exist";

            // Act
            var exception = await Record.ExceptionAsync(async () => await _emailService.SendEmail(email, CancellationToken.None));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<Exception>(exception);
            Assert.Equal(errorMessage, exception.Message);
        }
    }
}
