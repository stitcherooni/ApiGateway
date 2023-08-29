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
using BLL.FooGenerator;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.SortingService
{
    public class SortingService : ISortingService
    {
        public async Task<GetVolunteersFilters> VolunteersFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new GetVolunteersFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
                GroupBy = new GroupBy[2] { new GroupBy() { Id = "taskName", Name = "Task Name" }, new GroupBy { Id = "noGroup", Name = "No Group" } }
            };
            return response;
        }
        public async Task<GetVolunteerReportsResponse> SortVolunteerResponse(SortRequest sortRequest, CancellationToken cancellationToken)
        {
            return await ReportingDataGenerator.GetVolunteerReport(cancellationToken);
        }

        public async Task<GetTreasurerEventFilters> TreasurerByEventFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new GetTreasurerEventFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
                PaymentTypes = new PaymentTypes[2] { new PaymentTypes() { PaymentTypeId = "allPaymentTypes", PaymentTypeName = "All Payment Types" }, new PaymentTypes { PaymentTypeId = "complimentary", PaymentTypeName = "Complimentary" } }

            };
            return response;
        }
        public async Task<GetTreasurerByEventReportsResponse> SortTreasurerByEventResponse(SortTreasurerByEventRequest sortTreasurerByEventRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTreasurerByEventReport(cancellationToken);
            return response;
        }

        public async Task<TicketFilters> TicketsFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new TicketFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
                Filters = new Filters[4] { new Filters() { ProductId = 1, Product = "Tickets" }, new Filters { ProductId = 2, Product = "Vouchers" }, new Filters() { ProductId = 3, Product = "Grotto Boarding Passes" }, new Filters() { ProductId = 4, Product = "Prize Draws" } }
            };
            return response;
        }
        public async Task<GetTicketsReportsResponse> SortTicketsResponse(SortTicketsRequest sortTicketsRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetTicketReport(cancellationToken);
            return response;
        }

        public async Task<GetSalesFilters> SalesFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new GetSalesFilters()
            {
                Year = GetDataForSorting.GetLstOfYears(),
            };
            return response;
        }

        public async Task<GetProductQuestionsSortingFilters> ProductQuestionsFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new GetProductQuestionsSortingFilters()
            {
                Events = GetDataForSorting.GetEventList(),
                Products = GetDataForSorting.GetProductsForProductQuestions(),
                Format = GetDataForSorting.GetRandomFormat()

            };
            return response;
        }

        public async Task<object> SortProductQuestionsResponse(SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken)
        {
            if (sortProductQuestionsRequest.GroupBy == "horizontal")
                return await ReportingDataGenerator.GetProductQuestionHorizontalReport(cancellationToken);
            if (sortProductQuestionsRequest.GroupBy == "vertical")
                return await ReportingDataGenerator.GetProductQuestionVerticalReport(cancellationToken);
            else throw new Exception("Forman must be either 'horizontal' or 'vertical'.");
        }

        public async Task<GetChildBookingsFilters> ChildBookingsFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new GetChildBookingsFilters()
            {
                Events = GetDataForSorting.GetEventList(),
                GroupBy = GetDataForSorting.GetGroupByForChildBookings()
            };
            return response;
        }
        public async Task<GetChildOnlyBookingReportsResponse> SortChildBookingsResponse(SortChildBookingRequest sortChildBookingRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetChildOnlyBookingReport(cancellationToken);
            return response;
        }
 
        public async Task<GetBookingsSortingFilters> BookingsFilters(GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            var response = new GetBookingsSortingFilters()
            {
                Events = GetDataForSorting.GetEventList(),
                Products = GetDataForSorting.GetProductsForBooking(),
                GroupBy = GetDataForSorting.GetRandomGroup()

            };
            return response;
        }

        public async Task<GetBookingsReportsResponse> SortBookingsResponse(SortBookingRequest sortBookingRequest, CancellationToken cancellationToken)
        {
            var response = await ReportingDataGenerator.GetBookingReport(cancellationToken);
            return response;
        }
    }
}
