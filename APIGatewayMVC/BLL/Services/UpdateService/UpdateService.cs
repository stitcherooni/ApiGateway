using BLL.DTO.Update;
using BLL.DTO.Update.EditBooking;
using DAL.Repository.DBRepository;
using Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.UpdateService
{
    public class UpdateService : BaseService, IUpdateService
    {
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IRepository<TblOrder> _orderRepository;

        public UpdateService(IRepository<TblCustomer> customerRepository,
            IRepository<TblOrder> orderRepository
           )
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }

        public async Task RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken)
        {
            using (var transactionScope = GetTransactionScope())
            {
                var entity = await _customerRepository.FindAsync(removeUserRequest.UserId, cancellationToken);
                if (entity != null)
                {
                    entity.CustomerErasureDate = removeUserRequest.ErasureDate;
                    await _customerRepository.UpdateAsync(entity, cancellationToken);
                }
                else throw new Exception($"Customer with Id {removeUserRequest.UserId} doesn't exist");
                transactionScope.Complete();
            }
        }

        public async Task ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken)
        {
            using (var transactionScope = GetTransactionScope())
            {
                var entity = await _customerRepository.FindAsync(toggleApproveUserRequest.UserId, cancellationToken);
                if (entity != null)
                {
                    entity.CustomerApproved = true;
                    await _customerRepository.UpdateAsync(entity, cancellationToken);
                }
                else throw new Exception($"Customer with Id {toggleApproveUserRequest.UserId} doesn't exist");
                transactionScope.Complete();
            }
        }

        public async Task UnApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken)
        {
            using (var transactionScope = GetTransactionScope())
            {
                var entity = await _customerRepository.FindAsync(toggleApproveUserRequest.UserId, cancellationToken);
                if (entity != null)
                {
                    entity.CustomerApproved = false;
                    await _customerRepository.UpdateAsync(entity, cancellationToken);
                }
                else throw new Exception($"Customer with Id {toggleApproveUserRequest.UserId} doesn't exist");
                transactionScope.Complete();
            }
        }

        public async Task MarkNotDispatchedOrder(MarkAsNotDispatchedOrderRequest markAsNotDispatchedOrderRequest, CancellationToken cancellationToken)
        {
            using (var transactionScope = GetTransactionScope())
            {
                var entity = await _orderRepository.FindAsync(markAsNotDispatchedOrderRequest.OrderId, cancellationToken);

                if (entity != null)
                {
                    entity.OrderDispatched = false;
                    await _orderRepository.UpdateAsync(entity, cancellationToken);
                }
                else throw new Exception($"Order with Id {markAsNotDispatchedOrderRequest.OrderId} doesn't exist");
                transactionScope.Complete();
            }
        }

        public async Task DeleteOrder(DeleteOrderRequest deleteOrderRequest, CancellationToken cancellationToken)
        {
            using (var transactionScope = GetTransactionScope())
            {
                var entity = await _orderRepository.FindAsync(deleteOrderRequest.OrderId, cancellationToken);

                if (entity != null)
                {
                    entity.OrderDeleted = true;
                    await _orderRepository.UpdateAsync(entity, cancellationToken);
                }
                else throw new Exception($"Order with Id {deleteOrderRequest.OrderId} doesn't exist");
                transactionScope.Complete();
            }
        }

        public async Task EditBooking(EditBookingRequest editBookingRequest, CancellationToken cancellationToken)
        {
            if (IsValidAnswerType((JsonElement)editBookingRequest.Answers.Answer))
            {
                //TODO: Waiting for logic
            }
            else
            {
                throw new ValidationException("Invalid answer type");
            }
        }

        private bool IsValidAnswerType(JsonElement jsonElement)
        {
            return jsonElement.ValueKind switch
            {
                JsonValueKind.Array => IsValidArray(jsonElement.EnumerateArray()),
                JsonValueKind.String => true,
                JsonValueKind.Number => true,
                JsonValueKind.Object => IsValidObject(jsonElement.EnumerateObject()),
                JsonValueKind.True => true,
                JsonValueKind.False => true,
                _ => false,
            };
        }

        private bool IsValidArray(JsonElement.ArrayEnumerator arrayEnumerator)
        {
            while (arrayEnumerator.MoveNext())
            {
                if (!IsValidValue(arrayEnumerator.Current))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidObject(JsonElement.ObjectEnumerator objectEnumerator)
        {
            while (objectEnumerator.MoveNext())
            {
                if (!IsValidValue(objectEnumerator.Current.Value))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidValue(JsonElement valueElement)
        {
            return IsValidAnswerType(valueElement);
        }

    }
}
