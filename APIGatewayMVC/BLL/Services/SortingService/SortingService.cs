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
using BLL.FooGenerator;

namespace BLL.Services.SortingService
{
    public class SortingService : ISortingService
    {
        public async Task<GetVolunteersFilters> VolunteersFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new GetVolunteersFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
                GroupBy = new GroupBy[2] { new GroupBy() { Id = "taskName", Name = "Task Name" }, new GroupBy { Id = "noGroup", Name = "No Group" } }
            };
            return responce;
        }
        public async Task<GetVolunteerReportsResponse> SortVolunteerResponse(SortRequest sortRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            return await ReportingDataGenerator.GetVolunteerReport(cancellationToken, page, pageSize);
        }

        public async Task<GetTreasurerEventFilters> TreasurerByEventFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new GetTreasurerEventFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
                PaymentTypes = new PaymentTypes[2] { new PaymentTypes() { PaymentTypeId = "allPaymentTypes", PaymentTypeName = "All Payment Types" }, new PaymentTypes { PaymentTypeId = "complimentary", PaymentTypeName = "Complimentary" } }

            };
            return responce;
        }
        public async Task<GetTreasurerByEventReportsResponse> SortTreasurerByEventResponse(SortTreasurerByEventRequest sortTreasurerByEventRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTreasurerByEventReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<TicketFilters> TicketsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new TicketFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
                Filters = new Filters[4] { new Filters() { ProductId = 1, Product = "Tickets" }, new Filters { ProductId = 2, Product = "Vouchers" }, new Filters() { ProductId = 3, Product = "Grotto Boarding Passes" }, new Filters() { ProductId = 4, Product = "Prize Draws" } }
            };
            return responce;
        }
        public async Task<GetTicketsReportsResponse> SortTicketsResponse(SortTicketsRequest sortTicketsRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetTicketReport(cancellationToken, page, pageSize);
            return response;
        }

        public async Task<GetSalesFilters> SalesFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new GetSalesFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
            };
            return responce;
        }

        public async Task<GetProductQuestinsSortingFilters> ProductQuestinsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new GetProductQuestinsSortingFilters()
            {
                Events = GetDataForSorting.GetEventList(),
                Products = GetDataForSorting.GetProductsForProductQuestions(),
                Format = GetDataForSorting.GetRandomFormat()

            };
            return responce;
        }
        public async Task<object> SortProductQuestionsResponse(SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            if (sortProductQuestionsRequest.GroupBy == "horizontal")
                return await ReportingDataGenerator.GetProductQuestionHorizontalReport(cancellationToken, page, pageSize);
            if (sortProductQuestionsRequest.GroupBy == "vertical")
                return await ReportingDataGenerator.GetProductQuestionVerticalReport(cancellationToken, page, pageSize);
            else throw new Exception("Forman must be either 'horizontal' or 'vertical'.");
        }

        public async Task<GetChildBookingsFilters> ChildBookingsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new GetChildBookingsFilters()
            {
                Events = GetDataForSorting.GetEventList(),
                GroupBy = GetDataForSorting.GetGroupByForChildBookings()
            };
            return responce;
        }
        public async Task<GetChildOnlyBookingReportsResponse> SortChildBookingsResponse(SortChildBookingRequest sortChildBookingRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken, page, pageSize);
            return response;
        }
 
        public async Task<GetBookingsSortingFilters> BookingsFilters(GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            var responce = new GetBookingsSortingFilters()
            {
                Events = GetDataForSorting.GetEventList(),
                Products = GetDataForSorting.GetProductsForBooking(),
                GroupBy = GetDataForSorting.GetRandomGroup()

            };
            return responce;
        }
        public async Task<GetBookingsReportsResponse> SortBookingsResponse(SortBookingRequest sortBookingRequest, CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await ReportingDataGenerator.GetBookingReport(cancellationToken, page, pageSize);
            return response;
        }
    }
}
