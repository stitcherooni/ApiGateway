using System;

namespace BLL.DTO.Statistic.Reports.Invoice
{
    public class InvoiceDTO
    {
        public int Num { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set;}
        public string Status { get; set; }
        public int Net { get; set; }
        public int Vat { get; set; }
        public int Total { get; set; }
        public string Currency { get; set; }
        public string Invoice { get; set; }
    }
}
