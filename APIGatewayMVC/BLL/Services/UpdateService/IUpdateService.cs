using BLL.DTO.Update;
using BLL.DTO.Update.EditBooking;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.UpdateService
{
    public interface IUpdateService
    {
        public Task RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken);
        public Task ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken);
        public Task MarkNotDispatchedOrder(MarkAsNotDispatchedOrderRequest markAsNotDispatchedOrderRequest, CancellationToken cancellationToken);
        public Task DeleteOrder(DeleteOrderRequest deleteOrderRequest, CancellationToken cancellationToken);
        public Task EditBooking(EditBookingRequest editBookingRequest, CancellationToken cancellationToken);
    }
}