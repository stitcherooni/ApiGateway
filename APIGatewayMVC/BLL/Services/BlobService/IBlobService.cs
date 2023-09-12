using BLL.DTO.Blobs;
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
        public byte[] GenerateBankedReportPdfResponse(GetFileRequest getBankedReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateBankedReportExcelResponse(GetFileRequest getBankedReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateBookingsReportPdfResponse(GetFileRequest getBookingsReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateBookingsReportExcelResponse(GetFileRequest getBookingsReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateChildOnlyBookingsPdfResponse(GetFileRequest getChildOnlyBookingsReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateChildOnlyBookingsExcelResponse(GetFileRequest getChildOnlyBookingsReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateCustomerReportExcelResponse(GetFileRequest getCustomerReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateCustomerReportPdfResponse(GetFileRequest getCustomerReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateOrdersReportExcelResponse(GetFileRequest getOrdersReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateOrdersReportPdfResponse(GetFileRequest getOrdersReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateExportOrderDeliveryPdfResponse(GetFileRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateProductQuestionsExcelResponse(GetFileRequest getProductQuestionsExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateProductQuestionsPdfResponse(GetFileRequest getProductQuestionsPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateTicketsExcelResponse(GetFileRequest getTicketsExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateTicketsPdfResponse(GetFileRequest getTicketsPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateTicketsReportCsvResponse(GetFileRequest getTicketsReportCsvRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByDateReportExcelResponse(GetFileRequest getTreasurerByDateReportExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByDateReportPdfResponse(GetFileRequest getTreasurerByDateReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByEventExcelResponse(GetFileRequest getTreasurerByEventExcelRequest, CancellationToken cancellationToken);
        public byte[] GenerateTreasurerByEventReportPdfResponse(GetFileRequest getTreasurerByEventReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateVolunteersReportPdfResponse(GetFileRequest getVolunteersReportPdfRequest, CancellationToken cancellationToken);
        public byte[] GenerateExportOrderDeliveryDocumentResponse(ExportOrderDeliveryNoteRequest exportOrderDeliveryNoteRequest, CancellationToken cancellationToken);
    }
}