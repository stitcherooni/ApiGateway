using BLL.DTO.Update;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.UpdateService
{
    public interface IUpdateService
    {
        public Task RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken);
        public Task ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken);
    }
}