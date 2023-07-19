﻿using BLL.DTO.Statistic;
using BLL.DTO.Statistic.Reports.Banked;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Customers;
using BLL.DTO.Statistic.Reports.Dashboard;
using BLL.DTO.Statistic.Reports.EmailTracker;
using BLL.DTO.Statistic.Reports.Invoice;
using BLL.DTO.Statistic.Reports.MiWizard;
using BLL.DTO.Statistic.Reports.Order;
using BLL.DTO.Statistic.Reports.PaymentMethods;
using BLL.DTO.Statistic.Reports.ProductQuestion;
using BLL.DTO.Statistic.Reports.Sales;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;
using BLL.FooGenerator;
using DAL.Repository.DBRepository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BLL.Services.Statistic
{
    public class DashboardStatisticService : IDashboardStatisticService
    {
        private readonly IRepository<TblPaymentMethod> _paybentMethodRepository;

        public DashboardStatisticService(IRepository<TblPaymentMethod> paybentMethodRepository)
        {
            _paybentMethodRepository = paybentMethodRepository;
        }

        public async Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetMi_WizardReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetCustomersReportsResponse> GetCustomerReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetCustomerReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetOrdersReportsResponse> GetOrderReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetOrderReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetSalesReportsResponse> GetSaleReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetSaleReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTicketReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetVolunteerReportsResponse> GetVolunteerReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetVolunteerReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetBookingsReportsResponse> GetBookingReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetBookingReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetProductQuestionsHorizontalReportsResponse> GetProductQuestionHorizontalReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetProductQuestionHorizontalReport(cancellationToken, page, pageSize);
            return response;
        }
        public async Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetProductQuestionVerticalReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetInvoiceReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetTreasurerByEventReportsResponse> GetTreasurerByEventReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTreasurerByEventReport(cancellationToken, page, pageSize);
            return response;
        }
        public async Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTreasurerByDateReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetBankedReportsResponse> GetBankedTransactionReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetBankedReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetEmailTrackerReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<DashboardData> GetDashboardData(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetDashboardData(cancellationToken, page, pageSize);
            return response;
        }

        public IEnumerable<PaymentMethods> GetPaymentMethods()
        {
            var methods = new List<PaymentMethods>();
            var idsList = _paybentMethodRepository.FindBy(x => x.PaymentMethodId != null);
            var result = new List<PaymentMethods>();
            foreach (var item in idsList)
            {
                result.Add(new PaymentMethods
                {
                    Id = item.PaymentMethodId,
                    Name = item.PaymentMethodName
                });
            }
            return result;

        }
    }
}