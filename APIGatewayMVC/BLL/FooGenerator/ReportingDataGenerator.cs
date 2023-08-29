using BLL.DTO;
using BLL.DTO.Email;
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
using BLL.DTO.Statistic.Reports.ProductQuestion.ForEventIdAndProductId;
using BLL.DTO.Statistic.Reports.Sale;
using BLL.DTO.Statistic.Reports.Sales;
using BLL.DTO.Statistic.Reports.Ticket;
using BLL.DTO.Statistic.Reports.Treasurer;
using BLL.DTO.Statistic.Reports.TreasurerByEvent;
using BLL.DTO.Statistic.Reports.Volunteer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.FooGenerator
{
    public static class ReportingDataGenerator
    {
        readonly static Random rnd = new Random();
        public static async Task<GetMiWizardsReportsResponse> GetMi_WizardReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.MiWizardReport(cancellationToken);

            var response = new GetMiWizardsReportsResponse
            {
                Data = result
            };
            return response;
        }

        public static async Task<GetCustomersReportsResponse> GetCustomerReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.CustomerReport(cancellationToken);

            var response = new GetCustomersReportsResponse
            {
                Data = result,
                CustomersCount = result.Count(),
                Currency = "GBP",
                TotalOrdersNumber = result.Select(x => x.Orders).ToList().Sum(),
                TotalOrderValue = result.Select(x => x.Value).ToList().Sum(),
                NotificationCounts = new NotificationCounts { PushNotificationsCount = rnd.Next(1, 100), EmailCount = rnd.Next(1, 100) }
            };
            return response;
        }

        public static async Task<GetOrdersReportsResponse> GetOrderReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.OrderReport(cancellationToken);

            var response = new GetOrdersReportsResponse
            {
                Data = result,
                TotalOrdersCount = result.Select(x => x.Orders).Sum(),
                AvgOrderValue = result.Select(x => x.Orders).Sum() / result.Count(),
                TotalOrderValue = result.Select(x => x.Value.Amount).Sum(),
                Refunded = rnd.Next(0, result.Count),
                Currency = "GBP"
            };
            return response;
        }

        public static async Task<GetTicketsReportsResponse> GetTicketReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.TicketReport(cancellationToken);

            var response = new GetTicketsReportsResponse
            {
                Data = result,
                Qr = "some Qr"
            };
            return response;
        }

        public static async Task<GetSalesReport> GetSaleReport(CancellationToken cancellationToken)
        {
            var response = new GetSalesReport
            {
                TotalSales = rnd.Next(1, 100),
                AvgSalesValue = rnd.Next(1, 100),
                TotalSalesValue = rnd.Next(1, 100),
                PlatformBookingFees = rnd.Next(1, 100),
                Currency = "GBP"
            };
            return response;
        }

        public static async Task<GetVolunteerReportsResponse> GetVolunteerReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.VolunteerReport(cancellationToken);

            var response = new GetVolunteerReportsResponse
            {
                Data = result
            };
            return response;
        }

        public static async Task<GetBookingsReportsResponse> GetBookingReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.BookingReport(cancellationToken);

            var response = new GetBookingsReportsResponse
            {
                Data = result,
                TotalProductQuantity = result.Select(x => x.Quantity).ToList().Sum()
            };
            return response;
        }

        public static async Task<GetBookingsProductsReportsResponse> GetBookingProductsReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.BookingReport(cancellationToken);

            var response = new GetBookingsProductsReportsResponse
            {
                Data = result
            };
            return response;
        }

        public static async Task<GetProductQuestionsHorizontalReportsResponse> GetProductQuestionHorizontalReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.ProductQuestionHorisontalReport(cancellationToken);

            var response = new GetProductQuestionsHorizontalReportsResponse
            {
                Data = result,
                Questions = GetReports.GetQuestions(cancellationToken)
            };
            return response;
        }

        public static async Task<GetProductQuestionsVerticalReportsResponse> GetProductQuestionVerticalReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.ProductQuestionVerticalReport(cancellationToken);

            var response = new GetProductQuestionsVerticalReportsResponse
            {
                Data = result,
                Questions = GetReports.GetQuestions(cancellationToken)
            };
            return response;
        }

        public static async Task<GetInvoicesReportsResponse> GetInvoiceReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.InvoiceReport(cancellationToken);

            var response = new GetInvoicesReportsResponse
            {
                Data = result
            };
            return response;
        }

        public static async Task<GetTreasurerByEventReportsResponse> GetTreasurerByEventReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.TreasurerByEventReport(cancellationToken);

            var response = new GetTreasurerByEventReportsResponse
            {
                Data = result,
                TotalSales = result.Count(),
                Profit = 10,
                ProcessingFeeNotPaid = 15,
                PlatformFeesNotPaid = 12
            };
            return response;
        }

        public static async Task<GetTreasurerByDateReportsResponse> GetTreasurerByDateReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.TreasurerByDateReport(cancellationToken);

            var response = new GetTreasurerByDateReportsResponse
            {
                Data = result,
                TotalSales = result.Count(),
                Profit = 10,
                ProcessingFeeNotPaid = 15,
                PlatformFeesNotPaid = 12
            };
            return response;
        }

        public static async Task<GetBankedReportsResponse> GetBankedReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.BankedTransactionReport(cancellationToken);

            var response = new GetBankedReportsResponse
            {
                Data = result,
                Currency = "GBP",
                TotalOrdersCount = result.Count(),
                TotalSalesAmount = new Price { Amount = result.Select(x => x.Value).ToList().Sum(), Currency = "GBP" },
                TotalBankedFee = new Price { Amount = result.Select(x => x.BankedFee).ToList().Sum(), Currency = "GBP" },
                TotalPlatformFees = new Price { Amount = result.Select(x => x.PlatformFee).ToList().Sum(), Currency = "GBP" },
            };
            return response;
        }

        public static async Task<GetChildOnlyBookingReportsResponse> GetChildOnlyBookingReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.ChildOnlyBookingReport(cancellationToken);

            var response = new GetChildOnlyBookingReportsResponse
            {
                Data = result,
                SoldQuantity = rnd.Next(0, 100)
            };
            return response;
        }

        public static async Task<GetEmailTrackerReportsResponse> GetEmailTrackerReport(CancellationToken cancellationToken)
        {
            var result = await GetReports.EmailTrackerReport(cancellationToken);

            var response = new GetEmailTrackerReportsResponse
            {
                Data = result,
                TotalEmailsDelivered = result.Select(x => x.Delivered == true).Count(),
                TotalEmailsOpened = result.Select(x => x.Opened == true).Count(),
                TotalEmailsSent = result.Count()
            };
            return response;
        }

        public static async Task<OrganisationDataResponse> GetOrganisationDataResponse(CancellationToken cancellationToken)
        {
            Random rnd = new Random();
            var response = new OrganisationDataResponse
            {
                Logo = "https://i.ytimg.com/vi/t5QShg70KJM/hqdefault.jpg",
                Email = rnd.Next(1, 100) + "@email.com",
                Facebook = rnd.Next(1, 100) + ".facebook.com",
                Location = GetReports.GetLocation(cancellationToken),
                RegistrationNo = rnd.Next(1000000, 10000000)
            };
            return response;
        }

        public static async Task<CommonLiveSales> GetCommonLiveSales(CancellationToken cancellationToken)
        {

            var result = await GetReports.GetCommonLiveSalesDictionary(cancellationToken);

            var response = new CommonLiveSales
            {
                Data = result
            };
            return response;
        }

        public static async Task<CurrentLiveSales> GetCurrentLiveSales(CancellationToken cancellationToken)
        {
            var result = await GetReports.GetCurrentLiveSalesDictionary(cancellationToken);

            var response = new CurrentLiveSales
            {
                ProductName = result.Item1,
                Data = result.Item2,
                TotalQuantityLeft=result.Item2.Select(x=>x.QuantityLeft).Sum(),
                TotalSales = result.Item2.Select(x => x.Sales).Sum(),
                TotalQuantitySold = result.Item2.Select(x => x.QuantitySold).Sum(),
                Currency= "GBP",

            };
            return response;
        }

        public static async Task<MonthlyOrders> GetMonthlyOrders(CancellationToken cancellationToken)
        {
            var monthList = GetReports.GetMonthYearListUntilToday();
            var resultMonthlyOrders = GetReports.GetListMonthlyOrder(monthList, cancellationToken);

            var responseMonthlyOrders = new MonthlyOrders
            {
                TotalOrders = resultMonthlyOrders.Sum(x => x.Orders),
                TotalSales = resultMonthlyOrders.Sum(x => x.Sales),
                Data = resultMonthlyOrders,
                Currency = "GBP"
            };

            return responseMonthlyOrders;
        }

        public static async Task<MonthlyCustomersRegistrations> GetMonthlyCustomersRegistration(CancellationToken cancellationToken)
        {
            var monthList = GetReports.GetMonthYearListUntilToday();
            var resultMonthlyCustomersRegistrations = GetReports.GetListMonthlyCustomersRegistrations(monthList, cancellationToken);

            var responseMonthlyCustomersRegistrations = new MonthlyCustomersRegistrations
            {
                TotalRegistrations = resultMonthlyCustomersRegistrations.Sum(x => x.Registrations),
                Data = resultMonthlyCustomersRegistrations
            };

            return responseMonthlyCustomersRegistrations;
        }

        public static async Task<LastOrdersList> GetLastOrders(CancellationToken cancellationToken)
        {
            var ordersList = await GetReports.GetOrderList(cancellationToken);

            var responseMonthlyOrders = new LastOrdersList
            {
                Data = ordersList,
            };

            return responseMonthlyOrders;
        }

        public static async Task<CurrentSalesReportResponse> GetProductsSoldByDayItem(CancellationToken cancellationToken)
        {
            var result = GetReports.GetProductsSoldByDayItem(cancellationToken);

            var response = new CurrentSalesReportResponse
            {
                SoldValue = new Dictionary<string, SoldItem> {
                { "someProductByDay", new SoldItem {
                Data = result.Data,
                } } }
            };
            return response;
        }

        public static async Task<CurrentSalesReportResponse> GetProductSoldSchool(CancellationToken cancellationToken)
        {
            var result = GetReports.GetProductSoldSchool(cancellationToken);

            var response = new CurrentSalesReportResponse
            {
                SoldValue = new Dictionary<string, SoldItem> {
                { "someProductSoldSchool", new SoldItem {
                Data = result.Data
                } } }
            };
            return response;
        }

        public static async Task<CurrentSalesReportResponse> GetProductOrderCount(CancellationToken cancellationToken)
        {
            var result = GetReports.GetProductOrderCount(cancellationToken);

            var response = new CurrentSalesReportResponse
            {
                SoldValue = new Dictionary<string, SoldItem> {
                { "someProductOrderCount", new SoldItem {
                Data = result.Data
                } } }
            };

            return response;
        }

        public static async Task<GetSalesReportsResponse> GetSalesReport(CancellationToken cancellationToken)
        {
            var response = await GetReports.GetSalesResponse(cancellationToken);
            return response;
        }

        public static async Task<GetBookingsReportsResponse> GetRandomBookingReport(int size, CancellationToken cancellationToken)
        {
            var result = await GetReports.BookingReport(cancellationToken, size);

            var response = new GetBookingsReportsResponse
            {
                Data = result
            };
            return response;
        }

        public static async Task<GetProductQuestionsAndAnswersResponse> GetProductQuestionsAndAnswers(GetProductQuestionsAndAnswersRequest getProductQuestionsAndAnswersRequest, CancellationToken cancellationToken)
        {
            var result = GetReports.GetQuestions(cancellationToken);

            var response = new GetProductQuestionsAndAnswersResponse
            {
                Questions = GetReports.GetQuestions(cancellationToken),
                Answers = GetReports.GetAnswers(cancellationToken)
            };

            return response;
        }

        public static async Task<SendEmailResponse> GetSendEmailResponse(CancellationToken cancellationToken)
        {
            return new SendEmailResponse
            {
                EmailCount = rnd.Next(0, 100),
                PushNotificationCount = rnd.Next(0, 100)
            };
        }
    }
}