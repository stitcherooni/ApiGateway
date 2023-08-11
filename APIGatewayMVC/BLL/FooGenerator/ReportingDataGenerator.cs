using BLL.DTO.Statistic;
using BLL.DTO.Statistic.Reports.Banked;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.ChildOnlyBooking;
using BLL.DTO.Statistic.Reports.Customers;
using BLL.DTO.Statistic.Reports.Dashboard;
using BLL.DTO.Statistic.Reports.EmailTracker;
using BLL.DTO.Statistic.Reports.Invoice;
using BLL.DTO.Statistic.Reports.MiWizard;
using BLL.DTO.Statistic.Reports.Order;
using BLL.DTO.Statistic.Reports.Organisation;
using BLL.DTO.Statistic.Reports.ProductQuestion;
using BLL.DTO.Statistic.Reports.Sale;
using BLL.DTO.Statistic.Reports.Sales;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;

namespace BLL.FooGenerator
{
    public static class ReportingDataGenerator
    {
        public static async Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.MiWizardReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetMiWizardsReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult
            };
            return response;
        }

        public static async Task<GetCustomersReportsResponse> GetCustomerReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.CustomerReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetCustomersReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                TotalOrdersNumber = 100,
                TotalOrderValue = new TotalDTO() { Amount = 140, Currency = "GBP" }
            };
            return response;
        }

        public static async Task<GetOrdersReportsResponse> GetOrderReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.OrderReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetOrdersReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                TotalProcessingFees = new TotalDTO() { Amount = 120, Currency = "GBP" },
                TotalSalesAmount = new TotalDTO() { Amount = 140, Currency = "GBP" },
                TotalPlatformFees = new TotalDTO() { Amount = 150, Currency = "GBP" }
            };
            return response;
        }

        public static async Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.TicketReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetTicketsReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                Qr = "some Qr"
            };
            return response;
        }

        public static async Task<GetVolunteerReportsResponse> GetVolunteerReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.VolunteerReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetVolunteerReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult
            };
            return response;
        }

        public static async Task<GetBookingsReportsResponse> GetBookingReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.BookingReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetBookingsReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult
            };
            return response;
        }

        public static async Task<GetProductQuestionsHorizontalReportsResponse> GetProductQuestionHorizontalReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.ProductQuestionHorisontalReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetProductQuestionsHorizontalReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                Questions = GetReports.GetQuestions(cancellationToken)
            };
            return response;
        }

        public static async Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.ProductQuestionVerticalReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetProductQuestionsVerticalReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                Questions = GetReports.GetQuestions(cancellationToken)
            };
            return response;
        }

        public static async Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.InvoiceReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetInvoicesReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult
            };
            return response;
        }

        public static async Task<GetTreasurerByEventReportsResponse> GetTreasurerByEventReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.TreasurerByEventReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetTreasurerByEventReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                TotalSales = paginatedResult.Count(),
                Profit = 10,
                ProcessingFeeNotPaid = 15,
                PlatformFeesNotPaid = 12
            };
            return response;
        }

        public static async Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.TreasurerByDateReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetTreasurerByDateReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                TotalSales = paginatedResult.Count(),
                Profit = 10,
                ProcessingFeeNotPaid = 15,
                PlatformFeesNotPaid = 12
            };
            return response;
        }

        public static async Task<GetBankedReportsResponse> GetBankedReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.BankedTransactionReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetBankedReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                TotalOrdersCount = paginatedResult.Count(),
                TotalSalesAmount = new TotalDTO { Amount = paginatedResult.Select(x => x.Value).ToList().Sum(), Currency = "GBP" },
                TotalBankedFee = new TotalDTO { Amount = paginatedResult.Select(x => x.BankedFee).ToList().Sum(), Currency = "GBP" },
                TotalPlatformFees = new TotalDTO { Amount = paginatedResult.Select(x => x.PlatformFee).ToList().Sum(), Currency = "GBP" },
            };
            return response;
        }

        public static async Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.ChildOnlyBookingReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetChildOnlyBookingReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
            };
            return response;
        }

        public static async Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.EmailTrackerReport(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetEmailTrackerReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult,
                TotalEmailsDelivered = paginatedResult.Select(x => x.Delivered == true).Count(),
                TotalEmailsOpened = paginatedResult.Select(x => x.Opened == true).Count(),
                TotalEmailsSent = paginatedResult.Count()
            };
            return response;
        }

        public static async Task<OrganisationDataResponse> GetOrganisationDataResponse(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            var response = new OrganisationDataResponse
            {
                Logo = rnd.Next(1, 100) + "-Logo",
                Email = rnd.Next(1, 100) + "@email.com",
                Facebook = rnd.Next(1, 100) + ".facebook.com",
                Location = GetReports.GetLocation(cancellationToken),
                RegistrationNo = rnd.Next(1000000, 10000000)
            };
            return response;
        }

        public static async Task<CommonLiveSales> GetCommonLiveSales(CancellationToken cancellationToken, int page, int pageSize)
        {

            var result = await GetReports.GetCommonLiveSalesDictionary(cancellationToken, page, pageSize);

            var response = new CommonLiveSales
            {
                Data = result
            };
            return response;
        }

        public static async Task<CurrentLiveSales> GetCurrentLiveSales(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = await GetReports.GetCurrentLiveSalesDictionary(cancellationToken, page, pageSize);

            int skipCount = (page - 1) * pageSize;
            var totalCount = result.Item2.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResult = result.Item2.Skip(skipCount).Take(pageSize);

            var response = new CurrentLiveSales
            {
                ProductName = result.Item1,
                Data = paginatedResult,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            };
            return response;
        }

        public static async Task<MonthlyOrders> GetMonthlyOrders(CancellationToken cancellationToken, int page, int pageSize)
        {
            var monthList = GetReports.GetMonthYearListUntilToday();
            var resultMonthlyCustomersRegistrations = GetReports.GetListMonthlyCustomersRegistrations(monthList, cancellationToken);
            var resultMonthlyOrders = GetReports.GetListMonthlyOrder(monthList, cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = resultMonthlyOrders.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResultMonthlyOrders = resultMonthlyOrders.Skip(skipCount).Take(pageSize);
            var paginatedResultMonthlyCustomersRegistrations = resultMonthlyCustomersRegistrations.Skip(skipCount).Take(pageSize);

            var responseMonthlyOrders = new MonthlyOrders
            {
                TotalOrders = resultMonthlyOrders.Sum(x => x.Orders),
                TotalSales = resultMonthlyOrders.Sum(x => x.Sales),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResultMonthlyOrders,
                Currency = "GBP"
            };

            return responseMonthlyOrders;
        }

        public static async Task<MonthlyCustomersRegistrations> GetMonthlyCustomersRegistration(CancellationToken cancellationToken, int page, int pageSize)
        {
            var monthList = GetReports.GetMonthYearListUntilToday();
            var resultMonthlyOrders = GetReports.GetListMonthlyOrder(monthList, cancellationToken);
            var resultMonthlyCustomersRegistrations = GetReports.GetListMonthlyCustomersRegistrations(monthList, cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = resultMonthlyOrders.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResultMonthlyOrders = resultMonthlyOrders.Skip(skipCount).Take(pageSize);
            var paginatedResultMonthlyCustomersRegistrations = resultMonthlyCustomersRegistrations.Skip(skipCount).Take(pageSize);

            var responseMonthlyCustomersRegistrations = new MonthlyCustomersRegistrations
            {
                TotalRegistrations = resultMonthlyCustomersRegistrations.Sum(x => x.Registrations),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResultMonthlyCustomersRegistrations
            };

            return responseMonthlyCustomersRegistrations;
        }

        public static async Task<LastOrdersList> GetLastOrders(CancellationToken cancellationToken, int page, int pageSize)
        {
            var ordersList = await GetReports.GetOrderList(cancellationToken);

            int skipCount = (page - 1) * pageSize;
            var totalCount = ordersList.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginatedResultMonthlyOrders = ordersList.Skip(skipCount).Take(pageSize);

            var responseMonthlyOrders = new LastOrdersList
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResultMonthlyOrders,
            };

            return responseMonthlyOrders;
        }

        public static async Task<CurrentSalesReportResponse> GetProductsSoldByDayItem(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = GetReports.GetProductsSoldByDayItem(cancellationToken, page, pageSize);

            var response = new CurrentSalesReportResponse
            {
                SoldValue = new Dictionary<string, SoldItem> {
                { "someProductByDay", new SoldItem {
                Data = result.Data,
                TotalPages=result.TotalPages,
                TotalCount=result.TotalCount,
                CurrentPage=result.TotalPages,
                PageSize=result.PageSize} } }
            };
            return response;
        }

        public static async Task<CurrentSalesReportResponse> GetProductSoldSchool(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = GetReports.GetProductSoldSchool(cancellationToken, page, pageSize);

            var response = new CurrentSalesReportResponse
            {
                SoldValue = new Dictionary<string, SoldItem> {
                { "someProductSoldSchool", new SoldItem {
                Data = result.Data,
                TotalPages=result.TotalPages,
                TotalCount=result.TotalCount,
                CurrentPage=result.TotalPages,
                PageSize=result.PageSize} } }
            };
            return response;
        }

        public static async Task<CurrentSalesReportResponse> GetProductOrderCount(CancellationToken cancellationToken, int page, int pageSize)
        {
            var result = GetReports.GetProductOrderCount(cancellationToken, page, pageSize);

            var response = new CurrentSalesReportResponse
            {
                SoldValue = new Dictionary<string, SoldItem> {
                { "someProductOrderCount", new SoldItem {
                Data = result.Data,
                TotalPages=result.TotalPages,
                TotalCount=result.TotalCount,
                CurrentPage=result.TotalPages,
                PageSize=result.PageSize} } }
            };

            return response;
        }

        public static async Task<GetSalesReportsResponse> GetSalesReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            var response = await GetReports.GetSalesResponse(cancellationToken, page, pageSize);
            return response;
        }
    }
}