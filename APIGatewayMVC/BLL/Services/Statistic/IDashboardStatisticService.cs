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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.Statistic
{
    public interface IDashboardStatisticService
    {
        public Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken);
        public Task<GetCustomersReportsResponse> GetCustomerReport(CancellationToken cancellationToken);
        public Task<GetOrdersReportsResponse> GetOrderReport(CancellationToken cancellationToken);
        public Task<GetSalesReport> GetSaleReport(CancellationToken cancellationToken);
        public Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken);
        public Task<GetVolunteerReportsResponse> GetVolunteerReport(CancellationToken cancellationToken);
        public Task<GetBookingsReportsResponse> GetBookingReport(CancellationToken cancellationToken);
        public Task<GetProductQuestionsHorizontalReportsResponse> GetProductQuestionHorizontalReport(CancellationToken cancellationToken);
        public Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken);
        public Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken);
        public Task<GetTreasurerByEventReportsResponse> GetTreasurerByEventReport(CancellationToken cancellationToken);
        public Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(CancellationToken cancellationToken);
        public Task<GetBankedReportsResponse> GetBankedTransactionReport(CancellationToken cancellationToken);
        public Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(CancellationToken cancellationToken);
        public Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(CancellationToken cancellationToken);
        public Task<GetBookingsReportsResponse> GetTestBookingReport(int? count, CancellationToken cancellationToken);
        public Task<GetOrdersReportsResponse> TestReportsOrders(CancellationToken cancellationToken);
        public Task<GetBankedReportsResponse> TestBankedTransaction(CancellationToken cancellationToken);
        public Task<GetChildOnlyBookingReportsResponse> GetTestChildBooking(CancellationToken cancellationToken);
        public Task<GetBookingsReportsResponse> GetTestBooking(CancellationToken cancellationToken);
        public Task<GetBookingsReportsResponse> GetRandomBookingReport(GetRandomBookingReport getRandomBookingReport, CancellationToken cancellationToken);
        public Task<GetBookingQuestionsAndAnswersResponse> GetBookingQuestionsAndAnswersResponse(GetBookingQuestionsAndAnswersRequest getBookingQuestionsAndAnswersRequest, CancellationToken cancellationToken);
        public Task<IEnumerable<PaymentMethods>> GetPaymentMethods(CancellationToken cancellationToken);
        public Task<CommonLiveSales> CommonLiveSalesData(CancellationToken cancellationToken);
        public Task<CurrentLiveSales> CurrentLiveSalesData(CancellationToken cancellationToken, int productId);
        public Task<MonthlyOrders> GetMonthlyOrders(CancellationToken cancellationToken);
        public Task<MonthlyCustomersRegistrations> GetMonthlyCustomersRegistration(CancellationToken cancellationToken);
        public Task<LastOrdersList> GetLastOrders(CancellationToken cancellationToken);
        public Task<LastOrdersList> GetTestOrders(CancellationToken cancellationToken);
        public Task<OrganisationDataResponse> OrganisationData(OrganisationDataRequest organisationDataRequest, CancellationToken cancellationToken);
        public Task<CurrentSalesReportResponse> GetCurrentSalesReport(GetSalesReportForProductRequest getSalesReportForProductRequest, CancellationToken cancellationToken);
        public Task<GetBookingsProductsReportsResponse> GetBookingProducts(GetBookingProductsRequest getBookingProductsRequest, CancellationToken cancellationToken);
        public Task<GetProductQuestionsAndAnswersResponse> GetProductQuestionsAndAnswers(GetProductQuestionsAndAnswersRequest getProductQuestionsAndAnswersRequest, CancellationToken cancellationToken);
        public Task<GetBankedReportsResponse> GetTestBankedReport(CancellationToken cancellationToken);
    }
}