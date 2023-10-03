using RestSharp;
using System.Threading.Tasks;

namespace DAL.Repository.EmailSender
{
    public interface IEmailSender
    {
        Task<IRestResponse> SendEmail(EmailDTO email);
    }
}
