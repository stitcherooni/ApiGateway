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
using BLL.FooGenerator;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.SearchingService
{
    public class SearchingService : ISearchingService
    {
        public async Task<GetCustomersReportsResponse> GetCustomerReport(SearchCustomersRequest customersRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetCustomerReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetOrdersReportsResponse> GetOrderReport(SearchOrdersRequest ordersRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetOrderReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(SearchTreasurerByDateRequest treasurerByDateRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTreasurerByDateReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(SearchEmailTrackerReportRequest emailTrackerReportRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetEmailTrackerReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(SearchChildOnlyBookingsRequest searchChildOnlyBookingsRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetTicketsReportsResponse> GetTicketReport(SearchTicketsRequest searchTicketsRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTicketReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetSalesReportsResponse> GetSalesReport(SalesReportRequest salesReportRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetSalesReport(cancellationToken, page, pageSize);
            return response;
        }
    }
}