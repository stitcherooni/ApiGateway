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

namespace BLL.Services.Statistic
{
    public interface IDashboardStatisticService
    {
        public Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetCustomersReportsResponse> GetCustomerReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetOrdersReportsResponse> GetOrderReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetSalesReportsResponse> GetSaleReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetVolunteerReportsResponse> GetVolunteerReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetBookingsReportsResponse> GetBookingReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetProductQuestionsHorizontalReportsResponse> GetProductQuestionHorizontalReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetTreasurerByEventReportsResponse> GetTreasurerByEventReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetBankedReportsResponse> GetBankedTransactionReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(CancellationToken cancellationToken, int page, int pageSize);
        public Task<DashboardData> GetDashboardData(CancellationToken cancellationToken, int page, int pageSize);
        public IEnumerable<PaymentMethods> GetPaymentMethods();
    }
}