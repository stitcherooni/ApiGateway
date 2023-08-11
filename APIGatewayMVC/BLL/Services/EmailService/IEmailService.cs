using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.EmailService
{
    public interface IEmailService
    {
        public Task<IRestResponse> SendEmail(string emailAddress, CancellationToken cancellationToken);
    }
}