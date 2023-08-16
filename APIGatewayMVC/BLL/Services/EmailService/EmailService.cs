﻿using BLL.DTO.Email;
using DAL;
using DAL.Repository.DBRepository;
using DAL.Repository.EmailSender;
using Models;
using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IEmailSender _emailSender;
        private readonly IRepository<TblCustomer> _customerRepository;

        public EmailService(IEmailSender emailSender, IRepository<TblCustomer> customerRepository)
        {
            _emailSender = emailSender;
            _customerRepository = customerRepository;
        }

        public async Task<IRestResponse> SendEmail(string emailAddress, CancellationToken cancellationToken)
        {
            if (await _customerRepository.CountAsync(x => x.CustomerEmail.ToLower() == emailAddress.ToLower(), cancellationToken) != 0)
            {
                //ToDo: Add EmailLogic here
                EmailDTO emailDTO = new EmailDTO()
                {
                    Topic = "write Topic here",
                    Body = "write Body here",
                    Address = emailAddress
                };
                var result = await _emailSender.SendEmail(emailDTO);
                return result;
            }
            else throw new Exception($"User with email {emailAddress} doesn't exist");
        }

        public async Task<IRestResponse> ResendConfirmationEmailForOrder(ResendConfirmationEmailForOrderRequest resendConfirmationEmailForOrderRequest, CancellationToken cancellationToken)
        {
            return new RestResponse();
         }
    }
}
