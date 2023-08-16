namespace BLL.DTO.Email
{
    public class ResendConfirmationEmailForOrderRequest
    {
        public int OrganizationId { get; set; }
        public int OrderId { get; set; }
    }
}
