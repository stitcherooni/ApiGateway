namespace BLL.DTO.Statistic.Reports.Invoice
{
    public class GetInvoicesReportsResponse : PagesInfoDTO
    {
        public IEnumerable<InvoiceDTO> Data { get; set; }
    }
}
