namespace BLL.DTO.Update
{
    public class ToggleApproveUserRequest
    {
        public int UserId { get; set; }
        public bool IsApprove { get; set; }
    }
}
