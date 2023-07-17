﻿using BLL.DTO;
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
using BLL.DTO.Statistic.Searching.Customer;
using BLL.DTO.Statistic.Searching.EmailTracker;
using BLL.DTO.Statistic.Searching.OnlyBookings;
using BLL.DTO.Statistic.Searching.Order;
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
    public class ReportController : ControllerBase
    {
        private readonly IDashboardStatisticService _dashbardStatisticService;
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
            _dashbardStatisticService = dashboardStatisticService;
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
                            var response = await _dashbardStatisticService.GetMi_WizardReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.customers):
                        {
                            var response = await _dashbardStatisticService.GetCustomerReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.orders):
                        {
                            var response = await _dashbardStatisticService.GetOrderReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.sales):
                        {
                            var response = await _dashbardStatisticService.GetSaleReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.tickets):
                        {
                            var response = await _dashbardStatisticService.GetTicketReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.volunteers):
                        {
                            var response = await _dashbardStatisticService.GetVolunteerReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.bookings):
                        {
                            var response = await _dashbardStatisticService.GetBookingReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.product_questionhorizontal):
                        {
                            var response = await _dashbardStatisticService.GetProductQuestionHorizontalReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.product_questionvertical):
                        {
                            var response = await _dashbardStatisticService.GetProductQuestionVerticalReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.invoices):
                        {
                            var response = await _dashbardStatisticService.GetInvoiceReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.treasurer_by_date):
                        {
                            var response = await _dashbardStatisticService.GetTreasurerByDateReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.treasurer_by_event):
                        {
                            var response = await _dashbardStatisticService.GetTreasurerByEventReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.banked):
                        {
                            var response = await _dashbardStatisticService.GetBankedTransactionReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.child_only_bookings):
                        {
                            var response = await _dashbardStatisticService.GetChildOnlyBookingReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }
                    case nameof(ReportTypes.email_tracker):
                        {
                            var response = await _dashbardStatisticService.GetEmailTrackerReport(cancellationToken, page, pageSize);
                            return Ok(response);
                        }

                    default: return BadRequest(new ResponseMessage() { Message = $"Type {getReportByTabRequest.Type} doesn't exist" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("dashboardData")]
        public async Task<IActionResult> GetDashboardData(CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _dashbardStatisticService.GetDashboardData(cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("paymentmethods")]
        public Task<IActionResult> GetPaymentMethods()
        {
            try
            {
                var result =  _dashbardStatisticService.GetPaymentMethods();
                return Task.FromResult<IActionResult>(Ok(result));
            }
            catch (Exception ex)
            {
                return Task.FromResult<IActionResult>(BadRequest(new ResponseMessage() { Message = ex.Message }));
            }
        }

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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("ordersexcel")]
        public async Task<IActionResult> GetBookingsReportExcel([FromQuery] GetOrdersReportExcelRequest getOrdersReportExcelRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateOrdersReportExcelResponse(getOrdersReportExcelRequest, cancellationToken);
                return File(blobData, "application/xlsx", "Orders.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("orderdeliverynotespdf")]
        public async Task<IActionResult> ExportOrderDeliveryNotReporeReportPdf([FromQuery] ExportOrderDeliveryNotePdfRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken)
        {
            try
            {
                byte[] blobData = _blobService.GenerateExportOrderDeliveryPdfResponse(exportOrderDeliveryNotePdfRequest, cancellationToken);
                return File(blobData, "application/pdf", "OrderDelivery.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("sales")]
        public async Task<IActionResult> GtSales([FromQuery] SalesReportRequest salesReportRequest, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _searchingService.GetSalesReport(salesReportRequest, cancellationToken);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        #endregion

        #region Sorting

        [HttpGet]
        [Route("volunteersfilters")]
        public async Task<IActionResult> GetVolunteersFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.VolunteersFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("treasurereventfilters")]
        public async Task<IActionResult> GetTreasurerEventFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.TreasurerByEventFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("ticketfilters")]
        public async Task<IActionResult> GetTicketFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.TicketsFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("salesfilters")]
        public async Task<IActionResult> GetSalesFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.SalesFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("froductquestinsfilters")]
        public async Task<IActionResult> GetProductQuestinsFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.ProductQuestinsFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }

            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("sortrroductquestions")]
        public async Task<IActionResult> SortProductQuestions([FromQuery] SortProductQuestionsRequest sortProductQuestionsRequest, CancellationToken cancellationToken, int page = 1, int pageSize = 10)
        {
            try
            {
                var result = await _sortingService.SortProductQuestionsResponse(sortProductQuestionsRequest, cancellationToken, page, pageSize);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("childbookingsfilters")]
        public async Task<IActionResult> GetChildBookingsFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.ChildBookingsFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("bookingsfilters")]
        public async Task<IActionResult> GetBookingsFilters([FromQuery] GetFIltersRequest getFIltersRequest, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _sortingService.BookingsFilters(getFIltersRequest, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
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
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        #endregion

        [HttpPut]
        [Route("removeuser")]
        public async Task<IActionResult> RemoveUser(RemoveUserRequest removeUserRequest, CancellationToken cancellationToken)
        {
            try
            {
                await _updateService.RemoveUser(removeUserRequest, cancellationToken);
                return Ok($"User with id {removeUserRequest.UserId} will be deleted {removeUserRequest.ErasureDate}");
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("approveuser")]
        public async Task<IActionResult> ApproveUser(ToggleApproveUserRequest toggleApproveUserRequest, CancellationToken cancellationToken)
        {
            try
            {
                await _updateService.ApproveUser(toggleApproveUserRequest, cancellationToken);
                return Ok($"User with Id {toggleApproveUserRequest.UserId} successfully approved");
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }
    }
}

