using RestSharp;

namespace DAL.Repository.EmailSender
{
    public interface IEmailSender
    {
        Task<IRestResponse> SendEmail(EmailDTO email);
    }
}
