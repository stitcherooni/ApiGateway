using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventFile
{
    public int EventFileId { get; set; }

    public TblEvent Event { get; set; }

    public TblFile File { get; set; }

    public bool EventFileDeleted { get; set; }

    public TblCustomer EventFileCreatedBy { get; set; }

    public DateTime EventFileCreatedDate { get; set; }

    public TblCustomer EventFileUpdatedBy { get; set; }

    public DateTime? EventFileUpdatedDate { get; set; }
}
