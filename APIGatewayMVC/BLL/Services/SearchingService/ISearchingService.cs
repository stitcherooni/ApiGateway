using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Customers;
using BLL.DTO.Statistic.Reports.EmailTracker;
using BLL.DTO.Statistic.Reports.Order;
using BLL.DTO.Statistic.Reports.Sales;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Searching.Customer;
using BLL.DTO.Statistic.Searching.EmailTracker;
using BLL.DTO.Statistic.Searching.OnlyBookings;
using BLL.DTO.Statistic.Searching.Order;
using BLL.DTO.Statistic.Searching.Sales;
using BLL.DTO.Statistic.Searching.Ticket;
using BLL.DTO.Statistic.Searching.TreasurerByDate;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.SearchingService
{
    public interface ISearchingService
    {
        public Task<GetCustomersReportsResponse> GetCustomerReport(SearchCustomersRequest customersRequest, CancellationToken cancellationToken);
        public Task<GetOrdersReportsResponse> GetOrderReport(SearchOrdersRequest ordersRequest, CancellationToken cancellationToken);
        public Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(SearchTreasurerByDateRequest treasurerByDateRequest, CancellationToken cancellationToken);
        public Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(SearchEmailTrackerReportRequest emailTrackerReportRequest, CancellationToken cancellationToken);
        public Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(SearchChildOnlyBookingsRequest searchChildOnlyBookingsRequest, CancellationToken cancellationToken);
        public Task<GetTicketsReportsResponse> GetTicketReport(SearchTicketsRequest searchTicketsRequest, CancellationToken cancellationToken);
        public Task<GetSalesReportsResponse> GetSalesReport(SalesReportRequest salesReportRequest, CancellationToken cancellationToken);
    }
}
