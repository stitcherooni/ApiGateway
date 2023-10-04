using Azure.Storage.Blobs;
using BLL.DTO;
using BLL.DTO.Blobs;
using BLL.DTO.Blobs.Bookings;
using BLL.DTO.Blobs.OrderDelivery;
using BLL.FooGenerator;
using DocumentGenerator;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
        public async Task<byte[]> GenerateBookingsReportPdfResponse(GetFileRequest getBookingsReportPdfRequest, CancellationToken cancellationToken)
        {
            var bookingReport = await ReportingDataGenerator.GetBookingReport(cancellationToken);

            List<BookingsTable> originalTable = new List<BookingsTable>();

            foreach (var bookingData in bookingReport.Data)
            {
                var booking = new BookingsTable
                {
                    In = bookingData.Num,
                    FirstName = bookingData.FirstName,
                    LastName = bookingData.LastName,
                    SKU = bookingData.Sku,
                    Product = bookingData.Product.Name,
                    Price = bookingData.Price,
                    BookingInfo = bookingData.BookingInfo,
                    Qty = bookingData.Quantity,
                    OrderId = bookingData.OrderId,
                    BookedBy = bookingData.CustomerName,
                    Telephone = bookingData.Phone,
                    PaymentMethod = bookingData.PaymentMethod,
                };

                originalTable.Add(booking);
            }
            List<Dictionary<string, string>> filteredTable = FilterTable(originalTable, getBookingsReportPdfRequest.Columns.ToList());

            List<string> headers = new();
            headers = filteredTable.FirstOrDefault().Keys.ToList();

            List<List<string>> tableValues = new();
            foreach (var value in filteredTable)
            {
                tableValues.Add(value.Values.ToList());
            }

            return _documentCreator.GenerateDocument("Bookings Report", headers, tableValues, DocumentGenerator.Templates.DocumentType.Pdf);
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

        public static List<Dictionary<string, string>> FilterTable(List<BookingsTable> originalTable, List<string> selectedColumns)
        {
            var filteredTable = originalTable.Select(item =>
            {
                var dict = new Dictionary<string, string>();
                foreach (var column in selectedColumns)
                {
                    switch (column)
                    {
                        case "In":
                            dict["In"] = item.In.ToString();
                            break;
                        case "FirstName":
                            dict["FirstName"] = item.FirstName;
                            break;
                        case "LastName":
                            dict["LastName"] = item.LastName;
                            break;
                        case "SKU":
                            dict["SKU"] = item.SKU.ToString();
                            break;
                        case "Product":
                            dict["Product"] = item.Product;
                            break;
                        case "Price":
                            dict["Price"] = item.Price.ToString();
                            break;
                        case "BookingInfo":
                            dict["BookingInfo"] = item.BookingInfo;
                            break;
                        case "Qty":
                            dict["Qty"] = item.Qty.ToString();
                            break;
                        case "OrderId":
                            dict["OrderId"] = item.OrderId.ToString();
                            break;
                        case "BookedBy":
                            dict["BookedBy"] = item.BookedBy;
                            break;
                        case "Telephone":
                            dict["Telephone"] = item.Telephone;
                            break;
                        case "PaymentMethod":
                            dict["PaymentMethod"] = item.PaymentMethod;
                            break;
                        case "Out":
                            dict["Out"] = item.Out;
                            break;
                    }
                }
                return dict;
            }).ToList();

            return filteredTable;
        }

        #endregion
    }
}
