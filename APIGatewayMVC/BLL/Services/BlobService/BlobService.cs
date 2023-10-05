using Azure.Storage.Blobs;
using BLL.DTO;
using BLL.DTO.Blobs;
using BLL.DTO.Blobs.OrderDelivery;
using BLL.FooGenerator;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentGenerator;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading;

namespace BLL.Services.BlobService
{
    public class BlobService : IBlobService
    {
        private readonly IOptionsMonitor<BlobSettings> _blobSettingsMonitor;
        private readonly IDocumentCreator _documentCreator;

        public BlobService(IOptionsMonitor<BlobSettings> blobSettingsMonitor, IDocumentCreator documentCreator)
        {
            _blobSettingsMonitor = blobSettingsMonitor;
            _documentCreator = documentCreator;
        }

        public byte[] TestHtmlConvertor(string html)
        {
            return _documentCreator.TestCreation(html);

            //TODO:          return GetBankedReportPdfResponse;
        }
        public byte[] GenerateBankedReportPdfResponse(GetFileRequest getBankedReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:          return GetBankedReportPdfResponse;
        }

        public byte[] GenerateBankedReportExcelResponse(GetFileRequest getBankedReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:           return GetBankedReportExcelResponse
        }
        public byte[] GenerateBookingsReportPdfResponse(GetFileRequest getBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetBookingsReportPdfResponse
        }
        public byte[] GenerateBookingsReportExcelResponse(GetFileRequest getBookingsReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetBookingsReportExcelResponse
        }
        public byte[] GenerateChildOnlyBookingsPdfResponse(GetFileRequest getChildOnlyBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetChildOnlyBookingsReportResponse
        }
        public byte[] GenerateChildOnlyBookingsExcelResponse(GetFileRequest getChildOnlyBookingsReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetChildOnlyBookingsReportResponse
        }
        public byte[] GenerateCustomerReportExcelResponse(GetFileRequest getCustomerReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetCustomerReportExcelResponse
        }
        public byte[] GenerateCustomerReportPdfResponse(GetFileRequest getCustomerReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetCustomerReportPdfResponse
        }
        public byte[] GenerateOrdersReportExcelResponse(GetFileRequest getOrdersReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetOrdersReportExcelResponse
        }
        public byte[] GenerateOrdersReportPdfResponse(GetFileRequest getOrdersReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetOrdersReportPdfResponse
        }
        public byte[] GenerateExportOrderDeliveryPdfResponse(GetFileRequest exportOrderDeliveryNotePdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return ExportOrderDeliveryNotePdfResponse
        }
        public byte[] GenerateProductQuestionsExcelResponse(GetFileRequest getProductQuestionsExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetProductQuestionsExcelResponse
        }
        public byte[] GenerateProductQuestionsPdfResponse(GetFileRequest getProductQuestionsPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetProductQuestionsPdfResponse
        }
        public byte[] GenerateTicketsExcelResponse(GetFileRequest getTicketsExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTicketsExcelResponse
        }
        public byte[] GenerateTicketsPdfResponse(GetFileRequest getTicketsPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTicketsPdfResponse
        }
        public byte[] GenerateTicketsReportCsvResponse(GetFileRequest getTicketsReportCsvRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateCSVFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTicketsReportCsvResponse
        }
        public byte[] GenerateTreasurerByDateReportExcelResponse(GetFileRequest getTreasurerByDateReportExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TOD:            return GetTreasurerByDateReportExcelResponse
        }
        public byte[] GenerateTreasurerByDateReportPdfResponse(GetFileRequest getTreasurerByDateReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTreasurerByDateReportPdfResponse
        }
        public byte[] GenerateTreasurerByEventExcelResponse(GetFileRequest getTreasurerByEventExcelRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreateExcelFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTreasurerByEventReportExcelResponse
        }
        public byte[] GenerateTreasurerByEventReportPdfResponse(GetFileRequest getTreasurerByEventReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetTreasurerByEventReportPdfResponse
        }
        public byte[] GenerateVolunteersReportPdfResponse(GetFileRequest getVolunteersReportPdfRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return GetVolunteersReportPdfResponse
        }

        public byte[] GenerateExportOrderDeliveryDocumentResponse(ExportOrderDeliveryNoteRequest exportOrderDeliveryNoteRequest, CancellationToken cancellationToken)
        {
            return FileGenerator.CreatePDFFile(GetDataForBlob.GetListRequest());
            //TODO:            return ExportOrderDeliveryNotePdfResponse
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
