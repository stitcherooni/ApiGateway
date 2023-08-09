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

namespace BLL.Services.SearchingService
{
    public interface ISearchingService
    {
        public Task<GetCustomersReportsResponse> GetCustomerReport(SearchCustomersRequest customersRequest, CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetOrdersReportsResponse> GetOrderReport(SearchOrdersRequest ordersRequest, CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(SearchTreasurerByDateRequest treasurerByDateRequest, CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(SearchEmailTrackerReportRequest emailTrackerReportRequest, CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(SearchChildOnlyBookingsRequest searchChildOnlyBookingsRequest, CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetTicketsReportsResponse> GetTicketReport(SearchTicketsRequest searchTicketsRequest, CancellationToken cancellationToken, int page, int pageSize);
        public Task<GetSalesReportsResponse> GetSalesReport(SalesReportRequest salesReportRequest, CancellationToken cancellationToken, int page, int pageSize);
    }
}
