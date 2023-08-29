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
        public async Task<GetCustomersReportsResponse> GetCustomerReport(SearchCustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetCustomerReport(cancellationToken);
            return response;
        }

        public async Task<GetOrdersReportsResponse> GetOrderReport(SearchOrdersRequest ordersRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetOrderReport(cancellationToken);
            return response;
        }

        public async Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(SearchTreasurerByDateRequest treasurerByDateRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTreasurerByDateReport(cancellationToken);
            return response;
        }

        public async Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(SearchEmailTrackerReportRequest emailTrackerReportRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetEmailTrackerReport(cancellationToken);
            return response;
        }

        public async Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(SearchChildOnlyBookingsRequest searchChildOnlyBookingsRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken);
            return response;
        }

        public async Task<GetTicketsReportsResponse> GetTicketReport(SearchTicketsRequest searchTicketsRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTicketReport(cancellationToken);
            return response;
        }

        public async Task<GetSalesReportsResponse> GetSalesReport(SalesReportRequest salesReportRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetSalesReport(cancellationToken);
            return response;
        }
    }
}