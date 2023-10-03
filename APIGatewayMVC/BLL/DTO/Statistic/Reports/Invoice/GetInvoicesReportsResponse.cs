using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Invoice
{
    public class GetInvoicesReportsResponse
    {
        public IEnumerable<InvoiceDTO> Data { get; set; }
    }
}
