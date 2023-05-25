using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductClass
{
    public int ProductClassId { get; set; }

    public int ProductId { get; set; }

    public int ClassId { get; set; }

    public bool ProductClassDeleted { get; set; }

    public int ProductClassCreatedBy { get; set; }

    public DateTime ProductClassCreatedDate { get; set; }

    public int? ProductClassUpdatedBy { get; set; }

    public int? ProductClassUpdatedDate { get; set; }
}
