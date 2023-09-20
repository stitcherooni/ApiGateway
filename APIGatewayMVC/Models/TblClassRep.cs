using System;

namespace Models;

public partial class TblClassRep
{
    public int ClassRepId { get; set; }

    public int ClassId { get; set; }

    public int CustomerId { get; set; }

    public bool ClassRepDeleted { get; set; }

    public int ClassRepCreatedBy { get; set; }

    public DateTime ClassRepCreatedDate { get; set; }

    public int? ClassRepUpdatedBy { get; set; }

    public DateTime? ClassRepUpdatedDate { get; set; }

    public TblClass Class { get; set; }
    public TblCustomer Customer { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
