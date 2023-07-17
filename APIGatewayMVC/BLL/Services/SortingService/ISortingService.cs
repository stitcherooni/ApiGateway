using BLL.DTO.Sorting;
using BLL.DTO.Sorting.Booking;
using BLL.DTO.Sorting.BookingFilters;
using BLL.DTO.Sorting.EventFilters;
using BLL.DTO.Sorting.ProductQuestinsSortingFilters;
using BLL.DTO.Sorting.SalesFilters;
using BLL.DTO.Sorting.TicketFilters;
using BLL.DTO.Sorting.VolunteersFilters;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;

namespace BLL.Services.SortingService
{
    public interface ISortingService
    {
        public Task<GetVolunteersFilters> VolunteersFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);
        public Task<GetVolunteerReportsResponse> SortVolunteerResponse(SortRequest sortRequest, CancellationToken cancellationToken, int page, int pageSize);

        public Task<GetTreasurerEventFilters> TreasurerByEventFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);
        public Task<GetTreasurerByEventReportsResponse> SortTreasurerByEventResponse(SortTreasurerByEventRequest sortTreasurerByEventRequest, CancellationToken cancellationToken, int page, int pageSize);

        public Task<TicketFilters> TicketsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);
        public Task<GetTicketsReportsResponse> SortTicketsResponse(SortTicketsRequest sortTicketsRequest, CancellationToken cancellationToken, int page, int pageSize);

        public Task<GetSalesFilters> SalesFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);

        public Task<GetProductQuestinsSortingFilters> ProductQuestinsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);
        public Task<object> SortProductQuestionsResponse(SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken, int page, int pageSize);

        public Task<GetChildBookingsFilters> ChildBookingsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);
        public Task<GetChildOnlyBookingReportsResponse> SortChildBookingsResponse(SortChildBookingRequest sortChildBookingRequest, CancellationToken cancellationToken, int page, int pageSize);

        public Task<GetBookingsSortingFilters> BookingsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken);
        public Task<GetBookingsReportsResponse> SortBookingsResponse(SortBookingRequest sortBookingRequest, CancellationToken cancellationToken, int page, int pageSize);
     }
}