namespace BLL.DTO.Update
{
    public class RemoveUserRequest
    {
        public int UserId { get; set; }

        [MinimumDataTime(ErrorMessage = "ErasureDate must not be earlier than the current date and time.")]
        public DateTime ErasureDate { get; set; }
    }
}
