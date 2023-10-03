using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace BLL.DTO.Email
{
    public class SendCustomerEmailRequest
    {
        public string Subject { get; set; }
        public string AppNotification { get; set; }
        public string Message { get; set; }
        public Blob Attachment1 { get; set; }
        public Blob Attachment2 { get; set; }
        [RegularExpression("^(Email_push_to_app|Email|App)$", ErrorMessage = "SendVia must be 'Email_push_to_app', 'Email' or 'App'.")]
        public string SendVia { get; set; }
        public string Token { get; set; }
    }
}
