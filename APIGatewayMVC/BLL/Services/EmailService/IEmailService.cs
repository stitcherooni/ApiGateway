using RestSharp;

namespace BLL.Services.EmailService
{
    public interface IEmailService
    {
        public Task<IRestResponse> SendEmail(string emailAdress);
    }
}