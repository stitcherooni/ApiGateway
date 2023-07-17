using Azure.Storage.Blobs;
using BLL.DTO;
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
using BLL.FooGenerator;
using Microsoft.Extensions.Options;

namespace BLL.Services.BlobService
{
    public class BlobService : IBlobService
    {
        private readonly IOptionsMonitor<BlobSettings> _blobSettingsMonitor;

        public BlobService(IOptionsMonitor<BlobSettings> blobSettingsMonitor)
        {
            _blobSettingsMonitor = blobSettingsMonitor;
        }

        public byte[] GenerateBankedReportPdfResponse(GetBankedReportPdfRequest getBankedReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:          return GetBankedReportPdfResponse;
        }

        public byte[] GenerateBankedReportExcelResponse(GetBankedReportExcelRequest getBankedReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:           return GetBankedReportExcelResponse
        }
        public byte[] GenerateBookingsReportPdfResponse(GetBookingsReportPdfRequest getBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetBookingsReportPdfResponse
        }
        public byte[] GenerateBookingsReportExcelResponse(GetBookingsReportExcelRequest getBookingsReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetBookingsReportExcelResponse
        }
        public byte[] GenerateChildOnlyBookingsPdfResponse(GetChildOnlyBookingsReportPdfRequest getChildOnlyBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetChildOnlyBookingsReportResponse
        }
        public byte[] GenerateCustomerReportExcelResponse(GetCustomerReportExcelRequest getCustomerReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetCustomerReportExcelResponse
        }
        public byte[] GenerateCustomerReportPdfResponse(GetCustomerReportPdfRequest getCustomerReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetCustomerReportPdfResponse
        }
        public byte[] GenerateOrdersReportExcelResponse(GetOrdersReportExcelRequest getOrdersReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetOrdersReportExcelResponse
        }
        public byte[] GenerateOrdersReportPdfResponse(GetOrdersReportPdfRequest getOrdersReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetOrdersReportPdfResponse
        }
        public byte[] GenerateExportOrderDeliveryPdfResponse(ExportOrderDeliveryNotePdfRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return ExportOrderDeliveryNotePdfResponse
        }
        public byte[] GenerateProductQuestionsExcelResponse(GetProductQuestionsExcelRequest getProductQuestionsExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetProductQuestionsExcelResponse
        }
        public byte[] GenerateProductQuestionsPdfResponse(GetProductQuestionsPdfRequest getProductQuestionsPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetProductQuestionsPdfResponse
        }
        public byte[] GenerateTicketsExcelResponse(GetTicketsExcelRequest getTicketsExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTicketsExcelResponse
        }
        public byte[] GenerateTicketsPdfResponse(GetTicketsPdfRequest getTicketsPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTicketsPdfResponse
        }
        public byte[] GenerateTicketsReportCsvResponse(GetTicketsReportCsvRequest getTicketsReportCsvRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateCSVFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTicketsReportCsvResponse
        }
        public byte[] GenerateTreasurerByDateReportExcelResponse(GetTreasurerByDateReportExcelRequest getTreasurerByDateReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TOD:            return GetTreasurerByDateReportExcelResponse
        }
        public byte[] GenerateTreasurerByDateReportPdfResponse(GetTreasurerByDateReportPdfRequest getTreasurerByDateReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTreasurerByDateReportPdfResponse
        }
        public byte[] GenerateTreasurerByEventExcelResponse(GetTreasurerByEventExcelRequest getTreasurerByEventExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTreasurerByEventReportExcelResponse
        }
        public byte[] GenerateTreasurerByEventReportPdfResponse(GetTreasurerByEventReportPdfRequest getTreasurerByEventReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTreasurerByEventReportPdfResponse
        }
        public byte[] GenerateVolunteersReportPdfResponse(GetVolunteersReportPdfRequest getVolunteersReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetVolunteersReportPdfResponse
        }


        #region private methods
        private Uri ConvertToBlob(string blobName, byte[] fileBytes)
        {

            BlobServiceClient blobServiceClient = new BlobServiceClient(_blobSettingsMonitor.CurrentValue.ConnectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_blobSettingsMonitor.CurrentValue.ContainerName);

            using (MemoryStream memoryStream = new MemoryStream(fileBytes))
            {
                BlobClient blobClient = containerClient.GetBlobClient(blobName);
                blobClient.Upload(memoryStream, true);

                return blobClient.Uri;
            }
        }
        #endregion
    }
}
