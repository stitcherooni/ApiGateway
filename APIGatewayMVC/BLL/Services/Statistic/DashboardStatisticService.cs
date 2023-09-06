using BLL.DTO.Sorting.Booking;
using BLL.DTO.Statistic.Reports.Banked;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.BookingQuestionsAndAnswers;
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
using BLL.DTO.Statistic.Reports.Sales;
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

        public async Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetMi_WizardReport(cancellationToken);
            return response;
        }

        public async Task<GetCustomersReportsResponse> GetCustomerReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetCustomerReport(cancellationToken);
            return response;
        }

        public async Task<GetOrdersReportsResponse> GetOrderReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetOrderReport(cancellationToken);
            return response;
        }

        public async Task<GetSalesReport> GetSaleReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetSaleReport(cancellationToken);
            return response;
        }

        public async Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTicketReport(cancellationToken);
            return response;
        }

        public async Task<GetVolunteerReportsResponse> GetVolunteerReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetVolunteerReport(cancellationToken);
            return response;
        }

        public async Task<GetBookingsReportsResponse> GetBookingReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBookingReport(cancellationToken);
            return response;
        }

        public async Task<GetProductQuestionsHorizontalReportsResponse> GetProductQuestionHorizontalReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetProductQuestionHorizontalReport(cancellationToken);
            return response;
        }
 
        public async Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetProductQuestionVerticalReport(cancellationToken);
            return response;
        }

        public async Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetInvoiceReport(cancellationToken);
            return response;
        }

        public async Task<GetTreasurerByEventReportsResponse> GetTreasurerByEventReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTreasurerByEventReport(cancellationToken);
            return response;
        }
 
        public async Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTreasurerByDateReport(cancellationToken);
            return response;
        }

        public async Task<GetBankedReportsResponse> GetBankedTransactionReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBankedReport(cancellationToken);
            return response;
        }

        public async Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken);
            return response;
        }

        public async Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetEmailTrackerReport(cancellationToken);
            return response;
        }

        public async Task<GetBankedReportsResponse> GetTestBankedReport(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBankedReport(cancellationToken);
            return response;
        }
        public async Task<GetBookingsReportsResponse> GetTestBookingReport(int? count, CancellationToken cancellationToken)
        {
            if (count == null)
                count = 1;
            if (count >= 100)
                count = 100;
            var response = await ReportingDataGenerator.GetTestBookingReport(count, cancellationToken);
            return response;
        }

        public async Task<IEnumerable<PaymentMethods>> GetPaymentMethods(CancellationToken cancellationToken)
        {
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

        public async Task<CurrentSalesReportResponse> GetCurrentSalesReport(GetSalesReportForProductRequest getSalesReportForProductRequest, CancellationToken cancellationToken)
        {

            if (getSalesReportForProductRequest.Type == nameof(ProductsSoldByDayItem))
            {
                return await ReportingDataGenerator.GetProductsSoldByDayItem(cancellationToken);
            }
            else if (getSalesReportForProductRequest.Type == nameof(ProductSoldSchool))
            {
                return await ReportingDataGenerator.GetProductSoldSchool(cancellationToken);
            }
            else if (getSalesReportForProductRequest.Type == nameof(ProductOrderCount))
            {
                return await ReportingDataGenerator.GetProductOrderCount(cancellationToken);
            }
            else
            {
                throw new ArgumentException("Invalid type", nameof(getSalesReportForProductRequest.Type));
            }
        }

        public async Task<GetOrdersReportsResponse> TestReportsOrders(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetOrderReport(cancellationToken);
            return response;
        }

        public async Task<GetBankedReportsResponse> TestBankedTransaction(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBankedReport(cancellationToken);
            return response;
        }

        public async Task<GetChildOnlyBookingReportsResponse> GetTestChildBooking(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken);
            return response;
        }

        public async Task<GetBookingsReportsResponse> GetTestBooking(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBookingReport(cancellationToken);
            return response;
        }

        public async Task<GetBookingsReportsResponse> GetRandomBookingReport(GetRandomBookingReport getRandomBookingReport, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetRandomBookingReport(getRandomBookingReport.Size, cancellationToken);
            return response;
        }

        public async Task<GetBookingQuestionsAndAnswersResponse> GetBookingQuestionsAndAnswersResponse(GetBookingQuestionsAndAnswersRequest getBookingQuestionsAndAnswersRequest, CancellationToken cancellationToken)
        {
            var response = await GetReports.GetBookingQuestionsAndAnswersReport(getBookingQuestionsAndAnswersRequest, cancellationToken);
            return response;
        }

        public async Task<CommonLiveSales> CommonLiveSalesData(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetCommonLiveSales(cancellationToken);
            return response;
        }

        public async Task<CurrentLiveSales> CurrentLiveSalesData(CancellationToken cancellationToken, int productId)
        {
            var response = await ReportingDataGenerator.GetCurrentLiveSales(cancellationToken);
            return response;
        }

        public async Task<MonthlyOrders> GetMonthlyOrders(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetMonthlyOrders(cancellationToken);
            return response;
        }

        public async Task<MonthlyCustomersRegistrations> GetMonthlyCustomersRegistration(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetMonthlyCustomersRegistration(cancellationToken);
            return response;
        }
 
        public async Task<OrganisationDataResponse> OrganisationData(OrganisationDataRequest organisationDataRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetOrganisationDataResponse(cancellationToken);
            return response;
        }
  
        public async Task<LastOrdersList> GetLastOrders(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetLastOrders(cancellationToken);
            return response;
        }

        public async Task<LastOrdersList> GetTestOrders(CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetLastOrders(cancellationToken);
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
