using System;

namespace Models;

public partial class TblRefund
{
    public int RefundId { get; set; }

    public int OrderId { get; set; }

    public decimal RefundValue { get; set; }

    public string RefundDescription { get; set; }

    public bool RefundAttributed { get; set; }

    public bool RefundDeleted { get; set; }

    public int RefundCreatedBy { get; set; }

    public DateTime RefundCreatedDate { get; set; }

    public int? RefundUpdatedBy { get; set; }

    public DateTime? RefundUpdatedDate { get; set; }

    public TblOrder Order { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
