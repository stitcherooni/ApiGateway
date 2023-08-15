using BLL.DTO.Sorting.Booking;
using BLL.DTO.Statistic.Reports.Banked;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Customers;
using BLL.DTO.Statistic.Reports.Dashboard;
using BLL.DTO.Statistic.Reports.EmailTracker;
using BLL.DTO.Statistic.Reports.Invoice;
using BLL.DTO.Statistic.Reports.MiWizard;
using BLL.DTO.Statistic.Reports.Order;
using BLL.DTO.Statistic.Reports.Organisation;
using BLL.DTO.Statistic.Reports.PaymentMethods;
using BLL.DTO.Statistic.Reports.ProductQuestion;
using BLL.DTO.Statistic.Reports.ProductQuestion.ForEventIdAndProductId;
using BLL.DTO.Statistic.Reports.Sale;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;
using BLL.DTO.Statistic.Searching.Sale;
using BLL.DTO.Statistic.Searching.Sales;
using BLL.FooGenerator;
using DAL.Repository.DBRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.Statistic
{
    public class DashboardStatisticService : IDashboardStatisticService
    {
        private readonly IRepository<TblPaymentMethod> _paymentMethodRepository;

        public DashboardStatisticService(IRepository<TblPaymentMethod> paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
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

        public async Task<IEnumerable<PaymentMethods>> GetPaymentMethods(CancellationToken cancellationToken)
        {
            var methods = new List<PaymentMethods>();
            var idsList = await _paymentMethodRepository.GetAllAsync(cancellationToken);
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
        public async Task<CurrentSalesReportResponse> GetCurrentSalesReport(GetSalesReportForProductRequest getSalesReportForProductRequest, CancellationToken cancellationToken, int page, int pageSize)
        {

            if (getSalesReportForProductRequest.Type == nameof(ProductsSoldByDayItem))
            {
                return await ReportingDataGenerator.GetProductsSoldByDayItem(cancellationToken, page, pageSize);
            }
            else if (getSalesReportForProductRequest.Type == nameof(ProductSoldSchool))
            {
                return await ReportingDataGenerator.GetProductSoldSchool(cancellationToken, page, pageSize);
            }
            else if (getSalesReportForProductRequest.Type == nameof(ProductOrderCount))
            {
                return await ReportingDataGenerator.GetProductOrderCount(cancellationToken, page, pageSize);
            }
            else
            {
                throw new ArgumentException("Invalid type", nameof(getSalesReportForProductRequest.Type));
            }
        }

        public async Task<CommonLiveSales> CommonLiveSalesData(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetCommonLiveSales(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<CurrentLiveSales> CurrentLiveSalesData(CancellationToken cancellationToken, int productId, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetCurrentLiveSales(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<MonthlyOrders> GetMonthlyOrders(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetMonthlyOrders(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<MonthlyCustomersRegistrations> GetMonthlyCustomersRegistration(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetMonthlyCustomersRegistration(cancellationToken, page, pageSize);
            return response;
        }
        public async Task<OrganisationDataResponse> OrganisationData(OrganisationDataRequest organisationDataRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetOrganisationDataResponse(cancellationToken);
            return response;
        }

        public IEnumerable<PaymentMethods> GetPaymentMethods()
        {
            var methods = new List<PaymentMethods>();
            var idsList = _paymentMethodRepository.FindBy(x => x.PaymentMethodId != null);
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
        public async Task<LastOrdersList> GetLastOrders(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetLastOrders(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetBookingsProductsReportsResponse> GetBookingProducts(GetBookingProductsRequest getBookingProductsRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBookingProductsReport(cancellationToken);
            return response;
        }

        public async Task<GetProductQuestionsAndAnswersResponse> GetProductQuestionsAndAnswers(GetProductQuestionsAndAnswersRequest getProductQuestionsAndAnswersRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetProductQuestionsAndAnswers(getProductQuestionsAndAnswersRequest, cancellationToken);
            return response;
        }
    }
}
