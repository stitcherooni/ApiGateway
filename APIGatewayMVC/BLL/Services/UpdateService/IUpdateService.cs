using BLL.DTO.Update;

namespace BLL.Services.UpdateService
{
    public interface IUpdateService
    {
        public Task RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken);
        public Task ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken);
    }
}