using DAL;
using DAL.Repository.DBRepository;
using DAL.Repository.EmailSender;
using Models;
using RestSharp;

namespace BLL.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IEmailSender _emailSender;
        private readonly IRepository<TblCustomer> _customerRepository;

        public EmailService(IEmailSender emailSender, IRepository<TblCustomer> customerRepository)
        {
            _emailSender = emailSender;
            _customerRepository = customerRepository;
        }

        public async Task<IRestResponse> SendEmail(string emailAdress)
        {
            try
            {
                if (await _customerRepository.CountAsync(x => x.CustomerEmail == emailAdress) != 0)
                {
                    //ToDo: Add EmailLogic here
                    EmailDTO emailDTO = new EmailDTO()
                    {
                        Topic = "write Topic here",
                        Body = "write Body here",
                        Address = emailAdress
                    };
                   var result =await _emailSender.SendEmail(emailDTO);
                    return result;
                }
                else throw new Exception($"User with email {emailAdress} doesn't exist");
            }
            catch (Exception ex)
            {
                throw new Exception("Email can't be sent" + $", {ex.Message}");
            }
        }
    }
}
