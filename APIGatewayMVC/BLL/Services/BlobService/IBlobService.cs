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
using System.Threading;

namespace BLL.Services.BlobService
{
    public interface IBlobService
    {
        public byte[] GenerateBankedReportPdfResponse(GetBankedReportPdfRequest getBankedReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateBankedReportExcelResponse(GetBankedReportExcelRequest getBankedReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateBookingsReportPdfResponse(GetBookingsReportPdfRequest getBookingsReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateBookingsReportExcelResponse(GetBookingsReportExcelRequest getBookingsReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateChildOnlyBookingsPdfResponse(GetChildOnlyBookingsReportPdfRequest getChildOnlyBookingsReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateCustomerReportExcelResponse(GetCustomerReportExcelRequest getCustomerReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateCustomerReportPdfResponse(GetCustomerReportPdfRequest getCustomerReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateOrdersReportExcelResponse(GetOrdersReportExcelRequest getOrdersReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateOrdersReportPdfResponse(GetOrdersReportPdfRequest getOrdersReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateExportOrderDeliveryPdfResponse(ExportOrderDeliveryNotePdfRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateProductQuestionsExcelResponse(GetProductQuestionsExcelRequest getProductQuestionsExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateProductQuestionsPdfResponse(GetProductQuestionsPdfRequest getProductQuestionsPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateTicketsExcelResponse(GetTicketsExcelRequest getTicketsExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateTicketsPdfResponse(GetTicketsPdfRequest getTicketsPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateTicketsReportCsvResponse(GetTicketsReportCsvRequest getTicketsReportCsvRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByDateReportExcelResponse(GetTreasurerByDateReportExcelRequest getTreasurerByDateReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByDateReportPdfResponse(GetTreasurerByDateReportPdfRequest getTreasurerByDateReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByEventExcelResponse(GetTreasurerByEventExcelRequest getTreasurerByEventExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByEventReportPdfResponse(GetTreasurerByEventReportPdfRequest getTreasurerByEventReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateVolunteersReportPdfResponse(GetVolunteersReportPdfRequest getVolunteersReportPdfRequest, CancellationToken cancellationToken);
    }
}