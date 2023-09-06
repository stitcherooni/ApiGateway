using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductClass
{
    public int ProductClassId { get; set; }

    public TblProduct Product { get; set; }

    public TblClass Class { get; set; }

    public bool ProductClassDeleted { get; set; }

    public TblCustomer ProductClassCreatedBy { get; set; }

    public DateTime ProductClassCreatedDate { get; set; }

    public TblCustomer ProductClassUpdatedBy { get; set; }

    public int? ProductClassUpdatedDate { get; set; }
}
