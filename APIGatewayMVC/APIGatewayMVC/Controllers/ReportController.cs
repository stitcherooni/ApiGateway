using BLL.DTO.Blobs;
using BLL.DTO.Blobs.OrderDelivery;
using BLL.DTO.Email;
using BLL.DTO.Sorting;
using BLL.DTO.Sorting.Booking;
using BLL.DTO.Sorting.BookingFilters;
using BLL.DTO.Sorting.EventFilters;
using BLL.DTO.Sorting.ProductQuestionsSortingFilters;
using BLL.DTO.Sorting.TicketFilters;
using BLL.DTO.Statistic.Reports;
using BLL.DTO.Statistic.Reports.Booking;
using BLL.DTO.Statistic.Reports.BookingQuestionsAndAnswers;
using BLL.DTO.Statistic.Reports.Organisation;
using BLL.DTO.Statistic.Reports.ProductQuestion.ForEventIdAndProductId;
using BLL.DTO.Statistic.Searching.Customer;
using BLL.DTO.Statistic.Searching.EmailTracker;
using BLL.DTO.Statistic.Searching.OnlyBookings;
using BLL.DTO.Statistic.Searching.Order;
using BLL.DTO.Statistic.Searching.Sale;
using BLL.DTO.Statistic.Searching.Sales;
using BLL.DTO.Statistic.Searching.Ticket;
using BLL.DTO.Statistic.Searching.TreasurerByDate;
using BLL.DTO.Update;
using BLL.DTO.Update.EditBooking;
using BLL.Services.BlobService;
using BLL.Services.EmailService;
using BLL.Services.SearchingService;
using BLL.Services.SortingService;
using BLL.Services.Statistic;
using BLL.Services.UpdateService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace APIGatewayMVC.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : BaseController
    {
        private readonly IDashboardStatisticService _dashboardStatisticService;
        private readonly IBlobService _blobService;
        private readonly ISearchingService _searchingService;
        private readonly ISortingService _sortingService;
        private readonly IUpdateService _updateService;
        private readonly IEmailService _emailService;
        private readonly ILogger<ReportController> _logger;

        public ReportController(IDashboardStatisticService dashboardStatisticService,
                                IBlobService blobService,
                                ISearchingService searchingService,
                                ISortingService sortingService,
                                IUpdateService updateService,
                                IEmailService emailService,
                                ILogger<ReportController> logger)
        {
            _dashboardStatisticService = dashboardStatisticService;
            _blobService = blobService;
            _searchingService = searchingService;
            _sortingService = sortingService;
            _updateService = updateService;
            _emailService = emailService;         
            _logger = logger;
        }

        ///TODO: Delete this endpoint!
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Need file!");
            }
            string html;

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                html = await reader.ReadToEndAsync();
            }
            var blobData = _blobService.TestHtmlConvertor(html);
            return File(blobData, "application/pdf", "test.pdf");
        }

        [HttpGet]
        [Route("datareport")]
        public async Task<IActionResult> GetReportingData([FromQuery] GetReportByTabRequest getReportByTabRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation($"Request received for report type: {getReportByTabRequest.Type}");
                switch (getReportByTabRequest.Type.ToLower())
                {
                    case nameof(ReportTypes.mi_wizard):
                        {
                            var response = await _dashboardStatisticService.GetMi_WizardReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.customers):
                        {
                            var response = await _dashboardStatisticService.GetCustomerReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.orders):
                        {
                            var response = await _dashboardStatisticService.GetOrderReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.sales):
                        {
                            var response = await _dashboardStatisticService.GetSaleReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.tickets):
                        {
                            var response = await _dashboardStatisticService.GetTicketReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.volunteers):
                        {
                            var response = await _dashboardStatisticService.GetVolunteerReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.bookings):
                        {
                            var response = await _dashboardStatisticService.GetBookingReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.product_questionhorizontal):
                        {
                            var response = await _dashboardStatisticService.GetProductQuestionHorizontalReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.product_questionvertical):
                        {
                            var response = await _dashboardStatisticService.GetProductQuestionVerticalReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.invoices):
                        {
                            var response = await _dashboardStatisticService.GetInvoiceReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.treasurer_by_date):
                        {
                            var response = await _dashboardStatisticService.GetTreasurerByDateReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.treasurer_by_event):
                        {
                            var response = await _dashboardStatisticService.GetTreasurerByEventReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.banked):
                        {
                            var response = await _dashboardStatisticService.GetBankedTransactionReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.child_only_bookings):
                        {
                            var response = await _dashboardStatisticService.GetChildOnlyBookingReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.email_tracker):
                        {
                            var response = await _dashboardStatisticService.GetEmailTrackerReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.bookingstest):
                        {
                            var response = await _dashboardStatisticService.GetTestBookingReport(cancellationToken);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.randombookings):
                        {
                            var response = await _dashboardStatisticService.GetRandomBookingReport(getReportByTabRequest.Count, cancellationToken);
                            return Ok(response);
                        }

                    default:
                        {
                            _logger.LogWarning($"Unknown report type requested: {getReportByTabRequest.Type}");
                            throw new Exception($"Type {getReportByTabRequest.Type} doesn't exist");
                        }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error generating report for {getReportByTabRequest.Type}");
                return BadRequest(GenerateErrorMessage(ex, $"Can't generate report for {getReportByTabRequest.Type}"));
            }
        }

        [HttpGet]
        [Route("paymentmethods")]
        public async Task<IActionResult> GetPaymentMethods(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching payment methods.");
                var result = await _dashboardStatisticService.GetPaymentMethods(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching payment methods.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get payment methods"));
            }
        }

        [HttpGet]
        [Route("testbankedreport")]
        public async Task<IActionResult> GetTestBankedReport(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching test banked report.");
                var result = await _dashboardStatisticService.GetTestBankedReport(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching test banked report. ");
                return BadRequest(GenerateErrorMessage(ex, "Can't get test banked report"));
            }
        }

        [HttpGet]
        [Route("bookingproducts")]
        public async Task<IActionResult> GetBookingProducts([FromQuery] GetBookingProductsRequest getBookingProductsRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching booking products.");
                var result = await _dashboardStatisticService.GetBookingProducts(getBookingProductsRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching booking products.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get booking products"));
            }
        }

        [HttpGet]
        [Route("productquestionsandanswers")]
        public async Task<IActionResult> GetProductQuestionsAndAnswers([FromQuery] GetProductQuestionsAndAnswersRequest getProductQuestionsAndAnswersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching product questions and answers.");
                var result = await _dashboardStatisticService.GetProductQuestionsAndAnswers(getProductQuestionsAndAnswersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching product questions and answers.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get product questions and answers"));
            }
        }

        [HttpGet]
        [Route("currentsales")]
        public async Task<IActionResult> GetCurrentSalesReport([FromQuery] GetSalesReportForProductRequest getSalesReportForProductRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching current sales report.");
                var result = await _dashboardStatisticService.GetCurrentSalesReport(getSalesReportForProductRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching current sales report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get current sales"));
            }
        }

        [HttpGet]
        [Route("lastorders")]
        public async Task<IActionResult> GetLastOrders(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching last orders report.");
                var result = await _dashboardStatisticService.GetLastOrders(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching last orders report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get last orders"));
            }
        }

        [HttpGet]
        [Route("testorders")]
        public async Task<IActionResult> GetTestOrders(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching test orders report.");
                var result = await _dashboardStatisticService.GetTestOrders(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching test orders report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get test orders"));
            }
        }

        #region Dashboard
        [HttpGet]
        [Route("commonlivesalesdata")]
        public async Task<IActionResult> GetCommonLiveSalesData(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for fetching common live sales data.");
                var result = await _dashboardStatisticService.CommonLiveSalesData(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching common live sales data.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get Common Live Sales data"));
            }
        }

        [HttpGet]
        [Route("currentlivesalesdata")]
        public async Task<IActionResult> GetCurrentLiveSalesData(CancellationToken cancellationToken, int productId)
        {
            try
            {
                _logger.LogInformation("Request received for fetching current live sales data.");
                var result = await _dashboardStatisticService.CurrentLiveSalesData(cancellationToken, productId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching current live sales data.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get Current Live Sales data"));
            }
        }

        [HttpGet]
        [Route("monthlyordersdata")]
        public async Task<IActionResult> GetMonthlyOrdersData(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for monthly orders data.");
                var result = await _dashboardStatisticService.GetMonthlyOrders(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching monthly orders data.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get Monthly Orders data"));
            }
        }

        [HttpGet]
        [Route("monthlycustomerregistration")]
        public async Task<IActionResult> GetMonthlyCustomersRegistration(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for monthly customers registration.");
                var result = await _dashboardStatisticService.GetMonthlyCustomersRegistration(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching monthly customers registration data.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get monthly customers registration data"));
            }
        }

        [HttpGet]
        [Route("bookingquestionsandanswers")]
        public async Task<IActionResult> GetBookingQuestionsAndAnswers([FromQuery] GetBookingQuestionsAndAnswersRequest getBookingQuestionsAndAnswersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for random bookings.");
                var result = await _dashboardStatisticService.GetBookingQuestionsAndAnswersResponse(getBookingQuestionsAndAnswersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching random bookings.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get random bookings"));
            }
        }

        [HttpGet]
        [Route("organisationdata")]
        public async Task<IActionResult> GetOrganisationData([FromQuery] OrganisationDataRequest organisationDataRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for organisation data\".");
                var result = await _dashboardStatisticService.OrganisationData(organisationDataRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching organisation data\".");
                return BadRequest(GenerateErrorMessage(ex, "Can't get organisation data"));
            }
        }

        #endregion

        #region Blobs

        [HttpPost]
        [Route("bankedspdf")]
        public async Task<IActionResult> GetBankedReportPdf(GetFileRequest getBankedReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for banked report in pdf.");
                byte[] blobData = _blobService.GenerateBankedReportPdfResponse(getBankedReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "BankedReport.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching banked report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate banked report in pdf"));
            }
        }

        [HttpPost]
        [Route("bankedsexcel")]
        public async Task<IActionResult> GetBankedReportExcel(GetFileRequest getBankedReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for banked report in excel.");
                byte[] blobData = _blobService.GenerateBankedReportExcelResponse(getBankedReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "BankedReport.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching banked report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate banked report in excel"));
            }
        }

        [HttpPost]
        [Route("bookingspdf")]
        public async Task<IActionResult> GetBookingsReportPdf(GetFileRequest getBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for booking report in pdf.");
                byte[] blobData = _blobService.GenerateBookingsReportPdfResponse(getBookingsReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "BookingsReport.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching booking report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate booking report in pdf"));
            }
        }

        [HttpPost]
        [Route("bookingsexcel")]
        public async Task<IActionResult> GetBookingsReportExcel(GetFileRequest getBookingsReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for booking report in excel.");
                byte[] blobData = _blobService.GenerateBookingsReportExcelResponse(getBookingsReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "BookingsReport.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching booking report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate booking report in excel"));
            }
        }

        [HttpPost]
        [Route("childonlybookingspdf")]
        public async Task<IActionResult> GetChildOnlyBookingsReportPdf(GetFileRequest getChildOnlyBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for child only booking report in pdf.");
                byte[] blobData = _blobService.GenerateChildOnlyBookingsPdfResponse(getChildOnlyBookingsReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "ChildOnlyBookings.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching child only booking report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate child only booking report in pdf"));
            }
        }

        [HttpPost]
        [Route("childonlybookingsexcel")]
        public async Task<IActionResult> GetChildOnlyBookingsReportExcel(GetFileRequest getChildOnlyBookingsReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for child only booking report in excel.");
                byte[] blobData = _blobService.GenerateChildOnlyBookingsExcelResponse(getChildOnlyBookingsReportExcelRequest, cancellationToken);
                return File(blobData, "application/excel", "ChildOnlyBookings.excel");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching child only booking report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate child only booking report in excel"));
            }
        }

        [HttpPost]
        [Route("customersexcel")]
        public async Task<IActionResult> GetCustomerReportExcel(GetFileRequest getCustomerReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for customer report in excel.");
                byte[] blobData = _blobService.GenerateCustomerReportExcelResponse(getCustomerReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "CustomerReport.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching customer report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate customer report in excel"));
            }
        }

        [HttpPost]
        [Route("customerspdf")]
        public async Task<IActionResult> GetCustomerReportPdf(GetFileRequest getCustomerReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for customer report in pdf.");
                byte[] blobData = _blobService.GenerateCustomerReportPdfResponse(getCustomerReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "CustomerReport.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching customer report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate customer report in pdf"));
            }
        }

        [HttpPost]
        [Route("ordersexcel")]
        public async Task<IActionResult> GetOrdersReportExcel(GetFileRequest getOrdersReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for  orders report in excel.");
                byte[] blobData = _blobService.GenerateOrdersReportExcelResponse(getOrdersReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "Orders.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching  orders report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate orders report in excel"));
            }
        }

        [HttpPost]
        [Route("orderspdf")]
        public async Task<IActionResult> GetOrdersReportPdf(GetFileRequest getOrdersReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for orders report in pdf.");
                byte[] blobData = _blobService.GenerateOrdersReportPdfResponse(getOrdersReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "Orders.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching orders report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate orders report in pdf"));
            }
        }

        [HttpPost]
        [Route("orderdeliverynotespdf")]
        public async Task<IActionResult> ExportOrderDeliveryNoteReportPdf(GetFileRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for export order delivery note report in pdf.");
                byte[] blobData = _blobService.GenerateExportOrderDeliveryPdfResponse(exportOrderDeliveryNotePdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "OrderDeliveryNote.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching export order delivery note report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate export order delivery note report in pdf"));
            }
        }

        [HttpPost]
        [Route("orderdeliverydocument")]
        public async Task<IActionResult> ExportOrderDeliveryDocument(ExportOrderDeliveryNoteRequest exportOrderDeliveryNoteRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for export order delivery note report in pdf.");
                byte[] blobData = _blobService.GenerateExportOrderDeliveryDocumentResponse(exportOrderDeliveryNoteRequest, cancellationToken);
                return File(blobData, "application/pdf", "OrderDeliveryNoteDocument.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching export order delivery note report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate export order delivery note report in pdf"));
            }
        }

        [HttpPost]
        [Route("productquestionsexcel")]
        public async Task<IActionResult> GetProductQuestionsReportExcel(GetFileRequest getProductQuestionsExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for product questions report in excel.");
                byte[] blobData = _blobService.GenerateProductQuestionsExcelResponse(getProductQuestionsExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "ProductQuestions.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching product questions report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate product questions report in excel"));
            }
        }

        [HttpPost]
        [Route("productquestionspdf")]
        public async Task<IActionResult> GetProductQuestionsReportPdf(GetFileRequest getProductQuestionsPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for product questions report in pdf.");
                byte[] blobData = _blobService.GenerateProductQuestionsPdfResponse(getProductQuestionsPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "ProductQuestions.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching product questions report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate product questions report in pdf"));
            }
        }

        [HttpPost]
        [Route("ticketsexcel")]
        public async Task<IActionResult> GetTicketsReportExcel(GetFileRequest getTicketsExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for tickets report in excel.");
                byte[] blobData = _blobService.GenerateTicketsExcelResponse(getTicketsExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "Tickets.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching tickets report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate tickets report in excel"));
            }
        }

        [HttpPost]
        [Route("ticketspdf")]
        public async Task<IActionResult> GetTicketsReportPdf(GetFileRequest getTicketsPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for tickets report in pdf.");
                byte[] blobData = _blobService.GenerateTicketsPdfResponse(getTicketsPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "Tickets.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching tickets report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate tickets report in pdf"));
            }
        }

        [HttpPost]
        [Route("ticketscsv")]
        public async Task<IActionResult> GetTicketsReportCsv(GetFileRequest getTicketsReportCsvRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for tickets report in csv.");
                byte[] blobData = _blobService.GenerateTicketsReportCsvResponse(getTicketsReportCsvRequest, cancellationToken);
                return File(blobData, "application/csv", "TicketsReport.csv");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching tickets report in csv.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate tickets report in csv"));
            }
        }

        [HttpPost]
        [Route("treasurerbydateexcel")]
        public async Task<IActionResult> GetTreasurerByDateReportExcel(GetFileRequest getTreasurerByDateReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for treasurer by date report in excel.");
                byte[] blobData = _blobService.GenerateTreasurerByDateReportExcelResponse(getTreasurerByDateReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "TreasurerByDate.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching treasurer by date report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate treasurer by date report in excel"));
            }
        }

        [HttpPost]
        [Route("treasurerbydatepdf")]
        public async Task<IActionResult> GetTreasurerByDateReportPdf(GetFileRequest getTreasurerByDateReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for treasurer by date report in pdf.");
                byte[] blobData = _blobService.GenerateTreasurerByDateReportPdfResponse(getTreasurerByDateReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "TreasurerByDate.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching treasurer by date report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate treasurer by date report in pdf"));
            }
        }

        [HttpPost]
        [Route("treasurerbyeventexcel")]
        public async Task<IActionResult> GetTreasurerByEventReportExcel(GetFileRequest getTreasurerByEventExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for treasurer by event report in excel.");
                byte[] blobData = _blobService.GenerateTreasurerByEventExcelResponse(getTreasurerByEventExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "TreasurerByEvent.xlsx");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching treasurer by event report in excel.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate treasurer by event report in excel"));
            }
        }

        [HttpPost]
        [Route("treasurerbyeventpdf")]
        public async Task<IActionResult> GetTreasurerByEventReportPdf(GetFileRequest getTreasurerByEventReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for treasurer by event report in pdf.");
                byte[] blobData = _blobService.GenerateTreasurerByEventReportPdfResponse(getTreasurerByEventReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "TreasurerByEvent.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching treasurer by event report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate treasurer by event report in pdf"));
            }
        }

        [HttpPost]
        [Route("volunteerspdf")]
        public async Task<IActionResult> GetVolunteersReportPdf(GetFileRequest getVolunteersReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for volunteers report in pdf.");
                byte[] blobData = _blobService.GenerateVolunteersReportPdfResponse(getVolunteersReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "VolunteersReport.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching Volunteers report in pdf.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate volunteers report in pdf"));
            }
        }

        #endregion

        #region Searching

        [HttpGet]
        [Route("emailtrackers")]
        public async Task<IActionResult> GetEmailTrackers([FromQuery] SearchEmailTrackerReportRequest emailTrackerReportRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for email trackers report.");
                var response = await _searchingService.GetEmailTrackerReport(emailTrackerReportRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching email trackers report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate email trackers report"));
            }
        }

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> GetCustomers([FromQuery] SearchCustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for customers report.");
                var response = await _searchingService.GetCustomerReport(customersRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching customers report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate customers report"));
            }
        }

        [HttpGet]
        [Route("orders")]
        public async Task<IActionResult> GetOrders([FromQuery] SearchOrdersRequest ordersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for orders report.");
                var response = await _searchingService.GetOrderReport(ordersRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching orders report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate orders report"));
            }
        }

        [HttpGet]
        [Route("treasurerbydate")]
        public async Task<IActionResult> GetTreasurerByDate([FromQuery] SearchTreasurerByDateRequest treasurerByDateRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for treasurer by date report.");
                var response = await _searchingService.GetTreasurerByDateReport(treasurerByDateRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching treasurer by date report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate treasurer by date report"));
            }
        }

        [HttpGet]
        [Route("childonlybookings")]
        public async Task<IActionResult> GetChildOnlyBookingReport([FromQuery] SearchChildOnlyBookingsRequest searchChildOnlyBookingsRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for child only booking report.");
                var response = await _searchingService.GetChildOnlyBookingReport(searchChildOnlyBookingsRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching child only booking report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate child only booking report"));
            }
        }

        [HttpGet]
        [Route("tickets")]
        public async Task<IActionResult> GetTicketReport([FromQuery] SearchTicketsRequest searchTicketsRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for ticket report.");
                var response = await _searchingService.GetTicketReport(searchTicketsRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching ticket report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate ticket report"));
            }
        }

        [HttpGet]
        [Route("sales")]
        public async Task<IActionResult> GtSales([FromQuery] SalesReportRequest salesReportRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sales report.");
                var response = await _searchingService.GetSalesReport(salesReportRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sales report.");
                return BadRequest(GenerateErrorMessage(ex, "Can't generate sales report"));
            }
        }

        #endregion

        #region Sorting

        [HttpGet]
        [Route("volunteersfilters")]
        public async Task<IActionResult> GetVolunteersFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for volunteers filters.");
                var result = await _sortingService.VolunteersFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching volunteers filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get volunteers filters"));
            }
        }

        [HttpGet]
        [Route("sortvolunteers")]
        public async Task<IActionResult> SortVolunteers([FromQuery] SortRequest sortRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sort volunteers.");
                var result = await _sortingService.SortVolunteerResponse(sortRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sort volunteers.");
                return BadRequest(GenerateErrorMessage(ex, "Can't sort volunteers"));
            }
        }

        [HttpGet]
        [Route("treasurerbyeventfilters")]
        public async Task<IActionResult> GetTreasurerByEventFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for treasurer by event filters.");
                var result = await _sortingService.TreasurerByEventFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching treasurer by event filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get treasurer by event filters"));
            }
        }

        [HttpGet]
        [Route("sorttreasurerbyevent")]
        public async Task<IActionResult> SortTreasurerByEvent([FromQuery] SortTreasurerByEventRequest sortTreasurerByEventRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sort treasurer by event.");
                var result = await _sortingService.SortTreasurerByEventResponse(sortTreasurerByEventRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sort treasurer by event.");
                return BadRequest(GenerateErrorMessage(ex, "Can't sort treasurer by event"));
            }
        }

        [HttpGet]
        [Route("ticketsfilters")]
        public async Task<IActionResult> GetTicketFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for ticket filters.");
                var result = await _sortingService.TicketsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching ticket filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get ticket filters"));
            }
        }

        [HttpGet]
        [Route("sorttickets")]
        public async Task<IActionResult> SortTickets([FromQuery] SortTicketsRequest sortTicketsRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sort tickets.");
                var result = await _sortingService.SortTicketsResponse(sortTicketsRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sort tickets.");
                return BadRequest(GenerateErrorMessage(ex, "Can't sort tickets"));
            }
        }

        [HttpGet]
        [Route("salesfilters")]
        public async Task<IActionResult> GetSalesFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sales filters.");
                var result = await _sortingService.SalesFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sales filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get sales filters"));
            }
        }

        [HttpGet]
        [Route("productquestionsfilters")]
        public async Task<IActionResult> GetProductQuestionsFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for product questions filters.");
                var result = await _sortingService.ProductQuestionsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching product questions filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get product questions filters"));
            }
        }

        [HttpGet]
        [Route("sortproductquestions")]
        public async Task<IActionResult> SortProductQuestions([FromQuery] SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sort product questions.");
                var result = await _sortingService.SortProductQuestionsResponse(sortProductQuestionsRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sort product questions.");
                return BadRequest(GenerateErrorMessage(ex, "Can't sort product questions"));
            }
        }

        [HttpGet]
        [Route("childbookingsfilters")]
        public async Task<IActionResult> GetChildBookingsFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for child bookings filters.");
                var result = await _sortingService.ChildBookingsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching child bookings filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get child bookings filters"));
            }
        }

        [HttpGet]
        [Route("sortchildbookings")]
        public async Task<IActionResult> SortChildBookings([FromQuery] SortChildBookingRequest sortChildBookingRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sort child bookings.");
                var result = await _sortingService.SortChildBookingsResponse(sortChildBookingRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sort child bookings.");
                return BadRequest(GenerateErrorMessage(ex, "Can't sort child bookings"));
            }
        }


        [HttpGet]
        [Route("bookingsfilters")]
        public async Task<IActionResult> GetBookingsFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for bookings filters.");
                var result = await _sortingService.BookingsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching bookings filters.");
                return BadRequest(GenerateErrorMessage(ex, "Can't get bookings filters"));
            }
        }

        [HttpGet]
        [Route("sortbookings")]
        public async Task<IActionResult> SortBooking([FromQuery] SortBookingRequest sortBookingRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for sort bookings.");
                var result = await _sortingService.SortBookingsResponse(sortBookingRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching sort bookings.");
                return BadRequest(GenerateErrorMessage(ex, "Can't sort bookings"));
            }
        }

        #endregion

        #region Update

        [HttpDelete]
        [Route("removeuser")]
        public async Task<IActionResult> RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for remove user.");
                await _updateService.RemoveUser(removeUserRequest, cancellationToken);
                return Ok(new { Message = $"User with id {removeUserRequest.UserId} will be deleted {removeUserRequest.ErasureDate}" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching remove user.");
                return BadRequest(GenerateErrorMessage(ex, "Can't remove user"));
            }
        }

        [HttpPut]
        [Route("toggleapprovaluser")]
        public async Task<IActionResult> ToggleApprovalUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken)
        {
            if (toggleApproveUserRequest.IsApprove == true)
            {
                try
                {
                    _logger.LogInformation("Request received for approve user.");
                    await _updateService.ApproveUser(toggleApproveUserRequest, cancellationToken);
                    return Ok(new { Message = $"User with Id {toggleApproveUserRequest.UserId} successfully approved" });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error while fetching approve user.");
                    return BadRequest(GenerateErrorMessage(ex, "Can't approve user"));
                }
            }
            else
            {
                try
                {
                    _logger.LogInformation("Request received for unapprove user.");
                    await _updateService.UnApproveUser(toggleApproveUserRequest, cancellationToken);
                    return Ok(new { Message = $"User with Id {toggleApproveUserRequest.UserId} successfully unapproved" });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error while fetching approve user.");
                    return BadRequest(GenerateErrorMessage(ex, "Can't approve user"));
                }
            }

        }

        [HttpPut]
        [Route("markasnotdispatchedorder")]
        public async Task<IActionResult> MarkAsNotDispatchedOrder(MarkAsNotDispatchedOrderRequest markAsNotDispatchedOrderRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for mark as not dispatched order.");
                await _updateService.MarkNotDispatchedOrder(markAsNotDispatchedOrderRequest, cancellationToken);
                return Ok(new { Message = $"Order with Id {markAsNotDispatchedOrderRequest.OrderId} marked as not dispatched" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching mark as not dispatched order.");
                return BadRequest(GenerateErrorMessage(ex, "Can't mark the order"));
            }
        }

        [HttpDelete]
        [Route("deleteorder")]
        public async Task<IActionResult> DeleteOrder(DeleteOrderRequest deleteOrderRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for delete order.");
                await _updateService.DeleteOrder(deleteOrderRequest, cancellationToken);
                return Ok(new { Message = $"Order with Id {deleteOrderRequest.OrderId} deleted" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching delete order.");
                return BadRequest(GenerateErrorMessage(ex, "Can't delete the order"));
            }
        }

        [HttpPost]
        [Route("editbooking")]
        public async Task<IActionResult> EditBooking(EditBookingRequest editBookingRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Request received for edit booking.");
                await _updateService.EditBooking(editBookingRequest, cancellationToken);
                return Ok(new { Message = "Booking was updated" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while edit booking.");
                return BadRequest(GenerateErrorMessage(ex, "Can't edit booking"));
            }
        }
        #endregion

        #region Emails
        [HttpPost]
        [Route("resendconfirmationemailfororder")]
        public async Task<IActionResult> ResendConfirmationEmailForOrder(ResendConfirmationEmailForOrderRequest resendConfirmationEmailForOrderRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Resend confirmation email for order.");
                await _emailService.ResendConfirmationEmailForOrder(resendConfirmationEmailForOrderRequest, cancellationToken);
                return Ok(new { Message = "Confirmation email for order was resented." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while resend confirmation email for order.");
                return BadRequest(GenerateErrorMessage(ex, "Can't resend confirmation email for order."));
            }
        }

        [HttpPost]
        [Route("sendnewsletteremail")]
        public async Task<IActionResult> SendNewsletterEmail(SendNewsletterEmailRequest sendNewsletterEmailRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Send news letter email for order.");
                var result = await _emailService.SendNewsletterEmail(sendNewsletterEmailRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while send news letter email for order.");
                return BadRequest(GenerateErrorMessage(ex, "Can't send news letter email for order."));
            }
        }

        [HttpPost]
        [Route("sendcustomeremail")]
        public async Task<IActionResult> SendCustomerEmail(SendCustomerEmailRequest sendCustomerEmailRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Send customer email for order.");
                await _emailService.SendCustomerEmail(sendCustomerEmailRequest, cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while send customer email for order.");
                return BadRequest(GenerateErrorMessage(ex, "Can't send customer email for order."));
            }
        }

        #endregion
    }
}

