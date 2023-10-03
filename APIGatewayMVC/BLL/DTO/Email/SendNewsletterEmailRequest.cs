namespace BLL.DTO.Email
{
    public class SendNewsletterEmailRequest: SendCustomerEmailRequest
    {
        public bool MarketingEmail { get; set; }
    }
}
