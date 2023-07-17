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
        public static async Task<DashboardData> GetDashboardData(CancellationToken cancellationToken, int page, int pageSize)
        {
            var monthlyOrders = await GetReports.GetMonthlyOrders(cancellationToken, page, pageSize);

            var response = new DashboardData()
            {
                Stat = GetReports.GetDashboardStatistic(cancellationToken),
                CurrentLiveSales = await GetCurrentLiveSales(cancellationToken, page, pageSize),
                MonthlyOrders = monthlyOrders.MonthlyOrders,
                MonthlyCustomersRegistrations = monthlyOrders.MonthlyCustomersRegistrations,
                LastOrders = await GetReports.GetOrderList(cancellationToken)

            };
            return response;
        }

        public static async Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.MiWizardReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.CustomerReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.OrderReport(cancellationToken);

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

        public static async Task<GetSalesReportsResponse> GetSaleReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.SaleReport(cancellationToken);

            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new GetSalesReportsResponse
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult
            };
            return response;
        }

        public static async Task<SaleDTO> GetSalesReport(CancellationToken cancellationToken)
        {
            var response = GetReports.GetSalesResponse(cancellationToken);
            return response;
        }

        public static async Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.TicketReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.VolunteerReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.BookingReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            Random rnd = new Random();
            Questions[] questions = new Questions[rnd.Next(1, 10)];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = CreateQuestions(i);
            }

            var result = await GetReports.ProductQuestionHorisontalReport(cancellationToken);

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
                Questions = questions
            };
            return response;
        }

        public static async Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;

            Random rnd = new Random();
            var count = rnd.Next(1, 10);
            List<Questions> questions = new ();
            for (int i = 0; i < count; i++)
            {
                questions.Add(CreateQuestions(i));
            }

            var result = await GetReports.ProductQuestionVerticalReport(cancellationToken);

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
                Questions = questions
            };
            return response;
        }

        public static async Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.InvoiceReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.TreasurerByEventReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.TreasurerByDateReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.BankedTransactionReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.ChildOnlyBookingReport(cancellationToken);

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
            int skipCount = (page - 1) * pageSize;

            var result = await GetReports.EmailTrackerReport(cancellationToken);

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

        #region private methods
        private static Questions CreateQuestions(int id)
        {
            Random rnd = new Random();
            return new Questions()
            {
                QuestionId = id,
                Question = rnd.Next().ToString()
            };
        }

        private static async Task<CurrentLiveSales> GetCurrentLiveSales(CancellationToken cancellationToken, int page, int pageSize)
        {
            int skipCount = (page - 1) * pageSize;

            var result = GetReports.GetCurrentLiveSalesDictionary(cancellationToken);

            var totalCount = result.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var paginatedResult = result.Skip(skipCount).Take(pageSize);

            var response = new CurrentLiveSales
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Data = paginatedResult
            };
            return response;
        }
        #endregion
    }
}
