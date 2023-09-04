using System;
using System.Collections.Generic;

namespace Models;

public partial class TblClassRep
{
    public int ClassRepId { get; set; }

    public TblClass Class { get; set; }

    public TblCustomer Customer { get; set; }

    public bool ClassRepDeleted { get; set; }

    public TblCustomer ClassRepCreatedBy { get; set; }

    public DateTime ClassRepCreatedDate { get; set; }

    public TblCustomer ClassRepUpdatedBy { get; set; }

    public DateTime? ClassRepUpdatedDate { get; set; }
}
