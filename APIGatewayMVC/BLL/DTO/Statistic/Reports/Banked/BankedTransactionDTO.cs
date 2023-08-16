using BLL.DTO.Statistic.Reports.Order;
using System;

namespace BLL.DTO.Statistic.Reports.Banked
{
    public class BankedTransactionDTO
    {
        public int Num { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public int BankedFee { get; set; }
        public int PlatformFee { get; set; }
        public OrderDTO Order { get; set; }
        public int TransactionId { get; set; }
    }
}
