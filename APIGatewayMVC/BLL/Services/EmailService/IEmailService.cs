using BLL.DTO.Email;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.EmailService
{
    public interface IEmailService
    {
        public Task<IRestResponse> SendEmail(string emailAddress, CancellationToken cancellationToken);
        public Task<IRestResponse> ResendConfirmationEmailForOrder(ResendConfirmationEmailForOrderRequest resendConfirmationEmailForOrderRequest, CancellationToken cancellationToken);
        public Task<SendEmailResponse> SendCustomerEmail(SendCustomerEmailRequest sendCustomerEmailRequest, CancellationToken cancellationToken);
        public Task<SendEmailResponse> SendNewsletterEmail(SendNewsletterEmailRequest sendNewsletterEmailRequest, CancellationToken cancellationToken);
    }
}