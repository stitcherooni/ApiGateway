using BLL.DTO.Email;
using BLL.FooGenerator;
using DAL;
using DAL.Repository.DBRepository;
using DAL.Repository.EmailSender;
using Models;
using RestSharp;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.EmailService
{
    public class EmailService : BaseService, IEmailService
    {
        private readonly IEmailSender _emailSender;
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IRepository<TblMessage> _messageRepository;
        private readonly IRepository<TblEmail> _emailRepository;
        private readonly IRepository<TblSchool> _schoolRepository;

        public EmailService(IEmailSender emailSender,
                            IRepository<TblCustomer> customerRepository,
                            IRepository<TblMessage> messageRepository,
                            IRepository<TblEmail> emailRepository,
                            IRepository<TblSchool> schoolRepository)
        {
            _emailSender = emailSender;
            _customerRepository = customerRepository;
            _messageRepository = messageRepository;
            _emailRepository = emailRepository;
            _schoolRepository = schoolRepository;
        }

        public async Task<IRestResponse> SendEmail(string emailAddress, CancellationToken cancellationToken)
        {
            if (await _customerRepository.CountAsync(x => x.CustomerEmail.ToLower() == emailAddress.ToLower(), cancellationToken) != 0)
            {
                //ToDo: Add EmailLogic here
                EmailDTO emailDTO = new EmailDTO()
                {
                    Topic = "write Topic here",
                    Body = "write Body here",
                    Address = emailAddress
                };
                var result = await _emailSender.SendEmail(emailDTO);
                return result;
            }
            else throw new Exception($"User with email {emailAddress} doesn't exist");
        }

        public async Task<IRestResponse> ResendConfirmationEmailForOrder(ResendConfirmationEmailForOrderRequest resendConfirmationEmailForOrderRequest, CancellationToken cancellationToken)
        {
            return new RestResponse();
        }

        public async Task SendCustomerEmail(SendCustomerEmailRequest sendCustomerEmailRequest, CancellationToken cancellationToken)
        {
            ///
            ///TODO: Get CustomerId and ApplicationId, check custoimer role
            ///
            int customerId = 0;
            int applicationId = 1;

            ///
            /// TODO: Create a message body from HTML template 
            /// 
            var messageBody = sendCustomerEmailRequest.Message;

            using (var transactionScope = GetTransactionScope())
            {
                var message = new TblMessage
            {
                MessageTypeId = 2,
                MessageTitle = sendCustomerEmailRequest.Subject,
                MessageText = messageBody,
                CustomerId = customerId
            };

            var newMessage = await _messageRepository.AddAsync(message, cancellationToken);

            var getEmailTo = GetEmailTo(customerId, applicationId);
            if (getEmailTo == null) 
                throw new Exception("Permission for customer doesn't exist"); 

            var getEmailFrom = GetEmailFrom(applicationId);

            var email = new TblEmail
            {
                EmailTemplateId = 0,
                MessageId = newMessage.MessageId,
                EmailTo = getEmailTo,
                EmailFrom = getEmailFrom,
                EmailReplyTo = GetEmailFrom(applicationId),
                EmailSubject = sendCustomerEmailRequest.Subject,
                EmailBody = messageBody,
                EmailAttachment1 = sendCustomerEmailRequest.Attachment1.ToString(),
                EmailAttachment2 = sendCustomerEmailRequest.Attachment2.ToString(),
                EmailMailGunId = "",
                EmailCreatedBy = customerId,
                EmailCreatedDate = DateTime.UtcNow
            };

            await _emailRepository.AddAsync(email, cancellationToken);
            }
        }

        public async Task<SendEmailResponse> SendNewsletterEmail(SendNewsletterEmailRequest sendNewsletterEmailRequest, CancellationToken cancellationToken)
        {
            return await ReportingDataGenerator.GetSendEmailResponse(cancellationToken);
        }

        #region Private methods
        private string GetEmailTo(int customerId, int applicationId)
        {
            string email = _customerRepository.QueryableSelect(x => x.ApplicationId == applicationId).Where(x => x.CustomerId == customerId).Select(x => x.CustomerEmail).FirstOrDefault();
            return email;
        }

        private string GetEmailFrom(int applicationId)
        {
            string directory = _schoolRepository.QueryableSelect(x => x.SchoolId == applicationId).Select(x => x.SchoolPtadirectory).FirstOrDefault();
            return directory + "@pta-events.co.uk";
        }
        #endregion
    }
}
