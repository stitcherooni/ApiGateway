using AutoMapper;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using DAL;
using DAL.Repository.DBRepository;
using DAL.Repository.EmailSender;
using Models;
using Moq;
using RestSharp;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace UntTestsTests
{
    public class EmailSenderServiceTests
    {
        private readonly Mock<IRepository<TblCustomer>> _customerRepositoryMock;
        private readonly Mock<IEmailSender> _emailSenderMock;
        private readonly EmailService _emailService;

        public EmailSenderServiceTests()
        {
            _customerRepositoryMock = new Mock<IRepository<TblCustomer>>();
            _emailSenderMock = new Mock<IEmailSender>();
            _emailService = new EmailService(_emailSenderMock.Object, _customerRepositoryMock.Object);
        }

        [Fact]
        public async Task SendEmail_ValidEmailAddress_ReturnsRestResponse()
        {
            // Arrange
            _customerRepositoryMock.Setup(repo => repo.CountAsync(
               It.IsAny<Expression<Func<TblCustomer, bool>>>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(1);

            var expectedResponse = new RestResponse
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = "Email sent successfully"
            };            
            _emailSenderMock.Setup(x => x.SendEmail(It.IsAny<EmailDTO>())).ReturnsAsync(expectedResponse);

            // Act
            var actualResponse = await _emailService.SendEmail(It.IsAny<string>(), It.IsAny<CancellationToken>());

            // Assert
            Assert.Equal(expectedResponse.StatusCode, actualResponse.StatusCode);
            Assert.Equal(expectedResponse.Content, actualResponse.Content);
            _customerRepositoryMock.Verify(repo => repo.CountAsync(It.IsAny<Expression<Func<TblCustomer, bool>>>(), It.IsAny<CancellationToken>()), Times.Once);
            _emailSenderMock.Verify(repo => repo.SendEmail(It.IsAny<EmailDTO>()), Times.Once);
        }

        [Fact]
        public async Task SendEmail_InvalidEmailAddress_ThrowsException()
        {
            // Arrange
            string emailAddress = "nonexistent@example.com";
            string errorMessage = $"User with email {emailAddress} doesn't exist";
            _customerRepositoryMock.Setup(repo => repo.CountAsync(
                It.IsAny<Expression<Func<TblCustomer, bool>>>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(0);

            // Act & Assert
            var actualResponse = await Assert.ThrowsAsync<Exception>(
                () => _emailService.SendEmail(emailAddress, CancellationToken.None));

            Assert.Equal(errorMessage, actualResponse.Message);
            _customerRepositoryMock.Verify(repo => repo.CountAsync(It.IsAny<Expression<Func<TblCustomer, bool>>>(), It.IsAny<CancellationToken>()), Times.Once);
            _emailSenderMock.Verify(repo => repo.SendEmail(It.IsAny<EmailDTO>()), Times.Never);
        }
    }
}
