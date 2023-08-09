using BLL.DTO.Blobs.Banked;
using BLL.DTO.Blobs.Bookings;
using BLL.DTO.Blobs.ChildOnlyBookings;
using BLL.DTO.Blobs.CustomerReport;
using BLL.DTO.Blobs.OrderDelivery;
using BLL.DTO.Blobs.Orders;
using BLL.DTO.Blobs.ProductQuestions;
using BLL.DTO.Blobs.Tickets;
using BLL.DTO.Blobs.TicketsReport;
using BLL.DTO.Blobs.TreasurerByDate;
using BLL.DTO.Blobs.TreasurerByEvent;
using BLL.DTO.Blobs.VolunteersReport;
using BLL.DTO.Sorting;
using BLL.DTO.Sorting.Booking;
using BLL.DTO.Sorting.BookingFilters;
using BLL.DTO.Sorting.EventFilters;
using BLL.DTO.Sorting.ProductQuestinsSortingFilters;
using BLL.DTO.Sorting.TicketFilters;
using BLL.DTO.Statistic.Reports;
using BLL.DTO.Statistic.Reports.Organisation;
using BLL.DTO.Statistic.Searching.Customer;
using BLL.DTO.Statistic.Searching.EmailTracker;
using BLL.DTO.Statistic.Searching.OnlyBookings;
using BLL.DTO.Statistic.Searching.Order;
using BLL.DTO.Statistic.Searching.Sale;
using BLL.DTO.Statistic.Searching.Sales;
using BLL.DTO.Statistic.Searching.Ticket;
using BLL.DTO.Statistic.Searching.TreasurerByDate;
using BLL.DTO.Update;
using BLL.Services.BlobService;
using BLL.Services.SearchingService;
using BLL.Services.SortingService;
using BLL.Services.Statistic;
using BLL.Services.UpdateService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace APIGatewayMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : BaseController
    {
        private readonly IDashboardStatisticService _dashboardStatisticService;
        private readonly IBlobService _blobService;
        private readonly ISearchingService _searchingService;
        private readonly ISortingService _sortingService;
        private readonly IUpdateService _updateService;

        public ReportController(IDashboardStatisticService dashboardStatisticService,
                                IBlobService blobService,
                                ISearchingService searchingService,
                                ISortingService sortingService,
                                IUpdateService updateService)
        {
            _dashboardStatisticService = dashboardStatisticService;
            _blobService = blobService;
            _searchingService = searchingService;
            _sortingService = sortingService;
            _updateService = updateService;
        }

        [HttpGet]
        [Route("datareport")]
        public async Task<IActionResult> GetReportingData([FromQuery] GetReportByTabRequest getReportByTabRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                switch (getReportByTabRequest.Type.ToLower())
                {
                    case nameof(ReportTypes.mi_wizard):
                        {
                            var response = await _dashboardStatisticService.GetMi_WizardReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.customers):
                        {
                            var response = await _dashboardStatisticService.GetCustomerReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.orders):
                        {
                            var response = await _dashboardStatisticService.GetOrderReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.sales):
                        {
                            var response = await _dashboardStatisticService.GetSaleReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.tickets):
                        {
                            var response = await _dashboardStatisticService.GetTicketReport(cancellationToken, page, pageSize);
                            return Ok(response);    
                        }
                    case nameof(ReportTypes.volunteers):
                        {
                            var response = await _dashboardStatisticService.GetVolunteerReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.bookings):
                        {
                            var response = await _dashboardStatisticService.GetBookingReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.product_questionhorizontal):
                        {
                            var response = await _dashboardStatisticService.GetProductQuestionHorizontalReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.product_questionvertical):
                        {
                            var response = await _dashboardStatisticService.GetProductQuestionVerticalReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.invoices):
                        {
                            var response = await _dashboardStatisticService.GetInvoiceReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.treasurer_by_date):
                        {
                            var response = await _dashboardStatisticService.GetTreasurerByDateReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.treasurer_by_event):
                        {
                            var response = await _dashboardStatisticService.GetTreasurerByEventReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.banked):
                        {
                            var response = await _dashboardStatisticService.GetBankedTransactionReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.child_only_bookings):
                        {
                            var response = await _dashboardStatisticService.GetChildOnlyBookingReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.email_tracker):
                        {
                            var response = await _dashboardStatisticService.GetEmailTrackerReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }

                    default: throw new Exception($"Type {getReportByTabRequest.Type} doesn't exist");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, $"Can't generate report for {getReportByTabRequest.Type}"));
            }
        }

         [HttpGet]
        [Route("paymentmethods")]
        public async Task<IActionResult> GetPaymentMethods(CancellationToken cancellationToken)
        {
            try
            {
                var result =await  _dashboardStatisticService.GetPaymentMethods(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Payment methods"));
            }
        }
        
        #region Dashboard
        [HttpGet]
        [Route("commonlivesalesdata")]
        public async Task<IActionResult> GetCommonLiveSalesData(CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _dashboardStatisticService.CommonLiveSalesData(cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Common Live Sales data"));
            }
        }

        [HttpGet]
        [Route("currentlivesalesdata")]
        public async Task<IActionResult> GetCurrentLiveSalesData(CancellationToken cancellationToken, int productId, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _dashboardStatisticService.CurrentLiveSalesData(cancellationToken, productId, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Current Live Sales data"));
            }
        }

        [HttpGet]
        [Route("monthlyordersdata")]
        public async Task<IActionResult> GetMonthlyOrdersData (CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _dashboardStatisticService.GetMonthlyOrders(cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Monthly Orders data"));
            }
        }

        [HttpGet]
        [Route("monthlycustomerregistration")]
        public async Task<IActionResult> GetMonthlyCustomersRegistration(CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _dashboardStatisticService.GetMonthlyCustomersRegistration(cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Monthly Customers Registration data"));
            }
        }

        [HttpGet]
        [Route("organisationdata")]
        public async Task<IActionResult> GetOrganisationData([FromQuery] OrganisationDataRequest organisationDataRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _dashboardStatisticService.OrganisationData(organisationDataRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Organisation data"));
            }
        }

        #endregion

        #region Blobs

        [HttpGet]
        [Route("bankedspdf")]
        public async Task<IActionResult> GetBankedReportPdf([FromQuery] GetBankedReportPdfRequest getBankedReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateBankedReportPdfResponse(getBankedReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "BankedReport.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Banked report in pdf"));
            }
        }

        [HttpGet]
        [Route("bankedsexcel")]
        public async Task<IActionResult> GetBankedReportExcel([FromQuery] GetBankedReportExcelRequest getBankedReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateBankedReportExcelResponse(getBankedReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "BankedReport.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Banked report in excel"));
            }
        }

        [HttpGet]
        [Route("bookingspdf")]
        public async Task<IActionResult> GetBookingsReportPdf([FromQuery] GetBookingsReportPdfRequest getBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateBookingsReportPdfResponse(getBookingsReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "BookingsReport.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Booking report in pdf"));
            }
        }

        [HttpGet]
        [Route("bookingsexcel")]
        public async Task<IActionResult> GetBookingsReportExcel([FromQuery] GetBookingsReportExcelRequest getBookingsReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateBookingsReportExcelResponse(getBookingsReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "BookingsReport.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Booking report in exel"));
            }
        }

        [HttpGet]
        [Route("childonlybookingspdf")]
        public async Task<IActionResult> GetChildOnlyBookingsReportPdf([FromQuery] GetChildOnlyBookingsReportPdfRequest getChildOnlyBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateChildOnlyBookingsPdfResponse(getChildOnlyBookingsReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "ChildOnlyBookings.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Child only booking report in pdf"));
            }
        }

        [HttpGet]
        [Route("customersexcel")]
        public async Task<IActionResult> GetCustomerReportExcel([FromQuery] GetCustomerReportExcelRequest getCustomerReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateCustomerReportExcelResponse(getCustomerReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "CustomerReport.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Customer report in excel"));
            }
        }

        [HttpGet]
        [Route("customerspdf")]
        public async Task<IActionResult> GetCustomerReportPdf([FromQuery] GetCustomerReportPdfRequest getCustomerReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateCustomerReportPdfResponse(getCustomerReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "CustomerReport.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Customer report in pdf"));
            }
        }

        [HttpGet]
        [Route("ordersexcel")]
        public async Task<IActionResult> GetOrdersReportExcel([FromQuery] GetOrdersReportExcelRequest getOrdersReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateOrdersReportExcelResponse(getOrdersReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "Orders.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Orders report in exel"));
            }
        }

        [HttpGet]
        [Route("orderspdf")]
        public async Task<IActionResult> GetOrdersReportPdf([FromQuery] GetOrdersReportPdfRequest getOrdersReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateOrdersReportPdfResponse(getOrdersReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "Orders.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Orders report in pdf"));
            }
        }

        [HttpGet]
        [Route("orderdeliverynotespdf")]
        public async Task<IActionResult> ExportOrderDeliveryNoteReportPdf([FromQuery] ExportOrderDeliveryNotePdfRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateExportOrderDeliveryPdfResponse(exportOrderDeliveryNotePdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "OrderDeliveryNote.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Export order delivery note report in pdf"));
            }
        }

        [HttpGet]
        [Route("productquestionsexcel")]
        public async Task<IActionResult> GetProductQuestionsReportExcel([FromQuery] GetProductQuestionsExcelRequest getProductQuestionsExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateProductQuestionsExcelResponse(getProductQuestionsExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "ProductQuestions.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Product questions report in excel"));
            }
        }

        [HttpGet]
        [Route("productquestionspdf")]
        public async Task<IActionResult> GetProductQuestionsReportPdf([FromQuery] GetProductQuestionsPdfRequest getProductQuestionsPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateProductQuestionsPdfResponse(getProductQuestionsPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "ProductQuestions.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Product questions report in pdf"));
            }
        }

        [HttpGet]
        [Route("ticketsexcel")]
        public async Task<IActionResult> GetTicketsReportExcel([FromQuery] GetTicketsExcelRequest getTicketsExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTicketsExcelResponse(getTicketsExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "Tickets.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Tickets report in excel"));
            }
        }

        [HttpGet]
        [Route("ticketspdf")]
        public async Task<IActionResult> GetTicketsReportPdf([FromQuery] GetTicketsPdfRequest getTicketsPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTicketsPdfResponse(getTicketsPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "Tickets.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Tickets report in pdf"));
            }
        }

        [HttpGet]
        [Route("ticketscsv")]
        public async Task<IActionResult> GetTicketsReportCsv([FromQuery] GetTicketsReportCsvRequest getTicketsReportCsvRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTicketsReportCsvResponse(getTicketsReportCsvRequest, cancellationToken);
                return File(blobData, "application/csv", "TicketsReport.csv");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Tickets report in csv"));
            }
        }

        [HttpGet]
        [Route("treasurerbydateexcel")]
        public async Task<IActionResult> GetTreasurerByDateReportExcel([FromQuery] GetTreasurerByDateReportExcelRequest getTreasurerByDateReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTreasurerByDateReportExcelResponse(getTreasurerByDateReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "TreasurerByDate.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Treasurer by date report in excel"));
            }
        }

        [HttpGet]
        [Route("treasurerbydatepdf")]
        public async Task<IActionResult> GetTreasurerByDateReportPdf([FromQuery] GetTreasurerByDateReportPdfRequest getTreasurerByDateReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTreasurerByDateReportPdfResponse(getTreasurerByDateReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "TreasurerByDate.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Treasurer by date report in pdf"));
            }
        }

        [HttpGet]
        [Route("treasurerbyeventexcel")]
        public async Task<IActionResult> GetTreasurerByEventReportExcel([FromQuery] GetTreasurerByEventExcelRequest getTreasurerByEventExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTreasurerByEventExcelResponse(getTreasurerByEventExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "TreasurerByEvent.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Treasurer by event report in excel"));
            }
        }

        [HttpGet]
        [Route("treasurerbyeventpdf")]
        public async Task<IActionResult> GetTreasurerByEventReportPdf([FromQuery] GetTreasurerByEventReportPdfRequest getTreasurerByEventReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateTreasurerByEventReportPdfResponse(getTreasurerByEventReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "TreasurerByEvent.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Treasurer by event report in pdf"));
            }
        }

        [HttpGet]
        [Route("volunteerspdf")]
        public async Task<IActionResult> GetVolunteersReportPdf([FromQuery] GetVolunteersReportPdfRequest getVolunteersReportPdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateVolunteersReportPdfResponse(getVolunteersReportPdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "VolunteersReport.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Volunteers report in pdf"));
            }
        }

        #endregion

        #region Searching

        [HttpGet]
        [Route("emailtrackers")]
        public async Task<IActionResult> GetEmailTrackers([FromQuery] SearchEmailTrackerReportRequest emailTrackerReportRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetEmailTrackerReport(emailTrackerReportRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Email trackers report"));
            }
        }

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> GetCustomers([FromQuery] SearchCustomersRequest customersRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetCustomerReport(customersRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Customers report"));
            }
        }

        [HttpGet]
        [Route("orders")]
        public async Task<IActionResult> GetOrders([FromQuery] SearchOrdersRequest ordersRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetOrderReport(ordersRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Orders report"));
            }
        }

        [HttpGet]
        [Route("treasurerbydate")]
        public async Task<IActionResult> GetTreasurerByDate([FromQuery] SearchTreasurerByDateRequest treasurerByDateRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetTreasurerByDateReport(treasurerByDateRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Treasurer by date report"));
            }
        }

        [HttpGet]
        [Route("childonlybookings")]
        public async Task<IActionResult> GetChildOnlyBookingReport([FromQuery] SearchChildOnlyBookingsRequest searchChildOnlyBookingsRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetChildOnlyBookingReport(searchChildOnlyBookingsRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Child only booking report"));
            }
        }

        [HttpGet]
        [Route("tickets")]
        public async Task<IActionResult> GetTicketReport([FromQuery] SearchTicketsRequest searchTicketsRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetTicketReport(searchTicketsRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Ticket report"));
            }
        }

        [HttpGet]
        [Route("sales")]
        public async Task<IActionResult> GtSales([FromQuery] SalesReportRequest salesReportRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var response = await _searchingService.GetSalesReport(salesReportRequest, cancellationToken, page, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Sales report"));
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
                var result = await _sortingService.VolunteersFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Volunteers filters"));
            }
        }

        [HttpGet]
        [Route("sortvolunteers")]
        public async Task<IActionResult> SortVolunteers([FromQuery] SortRequest sortRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortVolunteerResponse(sortRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't sort Volunteers"));
            }
        }

        [HttpGet]
        [Route("treasurerbyeventfilters")]
        public async Task<IActionResult> GetTreasurerByEventFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.TreasurerByEventFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Treasurer by event filters"));
            }
        }

        [HttpGet]
        [Route("sorttreasurerbyevent")]
        public async Task<IActionResult> SortTreasurerByEvent([FromQuery] SortTreasurerByEventRequest sortTreasurerByEventRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortTreasurerByEventResponse(sortTreasurerByEventRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't sort Treasurer by event"));
            }
        }

        [HttpGet]
        [Route("ticketsfilters")]
        public async Task<IActionResult> GetTicketFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.TicketsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Ticket filters"));
            }
        }

        [HttpGet]
        [Route("sorttickets")]
        public async Task<IActionResult> SortTickets([FromQuery] SortTicketsRequest sortTicketsRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortTicketsResponse(sortTicketsRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't sort Tickets"));
            }
        }

        [HttpGet]
        [Route("salesfilters")]
        public async Task<IActionResult> GetSalesFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.SalesFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Sales filters"));
            }
        }

        [HttpGet]
        [Route("productquestionsfilters")]
        public async Task<IActionResult> GetProductQuestionsFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.ProductQuestionsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Product questions filters"));
            }
        }

        [HttpGet]
        [Route("sortproductquestions")]
        public async Task<IActionResult> SortProductQuestions([FromQuery] SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortProductQuestionsResponse(sortProductQuestionsRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't sort Product questions"));
            }
        }

        [HttpGet]
        [Route("childbookingsfilters")]
        public async Task<IActionResult> GetChildBookingsFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.ChildBookingsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Child bookings filters"));
            }
        }

        [HttpGet]
        [Route("sortchildbookings")]
        public async Task<IActionResult> SortChildBookings([FromQuery] SortChildBookingRequest sortChildBookingRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortChildBookingsResponse(sortChildBookingRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't sort Child bookings"));
            }
        }


        [HttpGet]
        [Route("bookingsfilters")]
        public async Task<IActionResult> GetBookingsFilters([FromQuery] GetFiltersRequest getFiltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.BookingsFilters(getFiltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't get Bookings filters"));
            }
        }

        [HttpGet]
        [Route("sortbookings")]
        public async Task<IActionResult> SortSortBooking([FromQuery] SortBookingRequest sortBookingRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortBookingsResponse(sortBookingRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't sort Bookings"));
            }
        }

        #endregion

        #region Update

        [HttpPut]
        [Route("removeuser")]
        public async Task<IActionResult> RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken)
        {
            try
            {
                await _updateService.RemoveUser(removeUserRequest, cancellationToken);
                return Ok(new { Message = $"User with id {removeUserRequest.UserId} will be deleted {removeUserRequest.ErasureDate}" });
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't remove user"));
            }
        }

        [HttpPut]
        [Route("approveuser")]
        public async Task<IActionResult> ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken)
        {
            try
            {
                await _updateService.ApproveUser(toggleApproveUserRequest, cancellationToken);
                return Ok(new { Message = $"User with Id {toggleApproveUserRequest.UserId} successfully approved" });
            }
            catch (Exception ex)
            {
                return BadRequest(GenerateErrorMessage(ex, "Can't approve user"));
            }
        }
        #endregion
    }
}

