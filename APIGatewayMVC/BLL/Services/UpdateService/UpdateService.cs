using BLL.DTO.Update;
using DAL.Repository.DBRepository;
using Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.UpdateService
{
    public class UpdateService: IUpdateService
    {
        private readonly IRepository<TblCustomer> _customerRepository;

        public UpdateService(IRepository<TblCustomer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken)
        {
            var entity = await _customerRepository.FindAsync(removeUserRequest.UserId);
            if (entity != null)
            {
                entity.CustomerErasureDate = removeUserRequest.ErasureDate;
                await _customerRepository.UpdateAsync(entity, cancellationToken);
            }
            else throw new Exception($"Customer with Id {removeUserRequest.UserId} doesn't exist");
        }

        public async Task ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken)
        {
            var entity = await _customerRepository.FindAsync(toggleApproveUserRequest.UserId);
            if (entity != null)
            {
                entity.CustomerApproved = true;
                await _customerRepository.UpdateAsync(entity, cancellationToken);
            }
            else throw new Exception($"Customer with Id {toggleApproveUserRequest.UserId} doesn't exist");
        }
    }
}
