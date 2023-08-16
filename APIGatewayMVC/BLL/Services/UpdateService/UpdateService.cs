using BLL.DTO.Update;
using BLL.DTO.Update.EditBooking;
using DAL.Repository.DBRepository;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL.Services.UpdateService
{
    public class UpdateService : BaseService, IUpdateService
    {
        private readonly IRepository<TblCustomer> _customerRepository;
        private readonly IRepository<TblOrderItem> _orderItemRepository;
        private readonly IRepository<TblOrder> _orderRepository;
        private readonly IRepository<TblBooking> _bookingRepository;
        private readonly IRepository<TblProduct> _productRepository;
        private readonly IRepository<TblProductQuestionAnswer> _productQuestionAnswerRepository;
        private readonly IRepository<TblProductQuestion> _productQuestionRepository;
        private readonly IRepository<TblEvent> _eventRepository;
        private readonly IRepository<TblEventProduct> _eventProductRepository;

        public UpdateService(IRepository<TblCustomer> customerRepository, IRepository<TblOrderItem> orderItemRepository, IRepository<TblBooking> bookingRepository,
            IRepository<TblProduct> productRepository, IRepository<TblOrder> orderRepository, IRepository<TblProductQuestionAnswer> productQuestionAnswerRepository,
            IRepository<TblProductQuestion> productQuestionRepository, IRepository<TblEvent> eventRepository, IRepository<TblEventProduct> eventProductRepository,
            IRepository<TblSchool> schoolRepository, IRepository<TblClass> classRepository)
        {
            _customerRepository = customerRepository;
            _orderItemRepository = orderItemRepository;
            _orderRepository = orderRepository;
            _bookingRepository = bookingRepository;
            _productRepository = productRepository;
            _productQuestionAnswerRepository = productQuestionAnswerRepository;
            _productQuestionRepository = productQuestionRepository;
            _eventRepository = eventRepository;
            _eventProductRepository = eventProductRepository;
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

        public async Task MarkNotDispatchedOrder(MarkAsNotDispatchedOrderRequest markAsNotDispatchedOrderRequest, CancellationToken cancellationToken)
        {
            using (var transactionScope = GetTransactionScope())
            {
                var entity = await _orderRepository.FindAsync(markAsNotDispatchedOrderRequest.OrderId, cancellationToken);

                if (entity != null)
                {
                    entity.OrderDespatched = false;
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
            //TODO: Waiting for logic
        }

    }
}
