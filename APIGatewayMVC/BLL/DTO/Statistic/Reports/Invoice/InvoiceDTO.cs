﻿using System;

namespace BLL.DTO.Statistic.Reports.Invoice
{
    public class InvoiceDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public DateTime IssureDate { get; set; }
        public DateTime DueDate { get; set;}
        public string Status { get; set; }
        public int Net { get; set; }
        public int Vat { get; set; }
        public int Total { get; set; }
        public string Currency { get; set; }
        public string Invoice { get; set; }
    }
}
