using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;

namespace DAL.Repository.EmailSender
{
    public class MailGunEmailSender : IEmailSender
    {
        private readonly IOptionsMonitor<EmailSettings> emailSettingsMonitor;

        public MailGunEmailSender(IOptionsMonitor<EmailSettings> emailSettingsMonitor)
        {
            this.emailSettingsMonitor = emailSettingsMonitor;
        }

        public async Task<IRestResponse> SendEmail(EmailDTO email)
        {
            EmailSettings emailSettings = emailSettingsMonitor.CurrentValue;

            RestClient client = new RestClient();
            client.BaseUrl = new Uri(emailSettings.Uri);
            client.Authenticator = new HttpBasicAuthenticator("api", emailSettings.ApiKey);

            RestRequest request = new RestRequest();
            request.AddParameter("domain", emailSettings.Domain, ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", emailSettings.From);
            request.AddParameter("to", email.Address);
            request.AddParameter("subject", email.Topic);
            request.AddParameter("text", email.Body);
            request.Method = Method.POST;

            return await client.ExecuteTaskAsync(request);
        }
    }
}
