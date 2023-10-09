using BLL.DTO.Sorting;
using BLL.DTO.Sorting.Booking;
using BLL.DTO.Sorting.BookingFilters;
using BLL.DTO.Sorting.EventFilters;
using BLL.DTO.Sorting.ProductQuestionsSortingFilters;
using BLL.DTO.Sorting.SalesFilters;
using BLL.DTO.Sorting.TicketFilters;
using BLL.DTO.Sorting.VolunteersFilters;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.SortingService
{
    public interface ISortingService
    {
        public Task<GetVolunteersFilters> VolunteersFilters(CancellationToken cancellationToken);
        public Task<GetVolunteerReportsResponse> SortVolunteerResponse(SortRequest sortRequest, CancellationToken cancellationToken);

        public Task<GetTreasurerEventFilters> TreasurerByEventFilters(CancellationToken cancellationToken);
        public Task<GetTreasurerByEventReportsResponse> SortTreasurerByEventResponse(SortTreasurerByEventRequest sortTreasurerByEventRequest, CancellationToken cancellationToken);

        public Task<TicketFilters> TicketsFilters(CancellationToken cancellationToken);
        public Task<GetTicketsReportsResponse> SortTicketsResponse(SortTicketsRequest sortTicketsRequest, CancellationToken cancellationToken);

        public Task<GetSalesFilters> SalesFilters(CancellationToken cancellationToken);

        public Task<GetProductQuestionsSortingFilters> ProductQuestionsFilters(CancellationToken cancellationToken);
        public Task<object> SortProductQuestionsResponse(SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken);

        public Task<GetChildBookingsFilters> ChildBookingsFilters(CancellationToken cancellationToken);
        public Task<GetChildOnlyBookingReportsResponse> SortChildBookingsResponse(SortChildBookingRequest sortChildBookingRequest, CancellationToken cancellationToken);

        public Task<GetBookingsSortingFilters> BookingsFilters(CancellationToken cancellationToken);
        public Task<GetBookingsReportsResponse> SortBookingsResponse(SortBookingRequest sortBookingRequest, CancellationToken cancellationToken);
     }
}