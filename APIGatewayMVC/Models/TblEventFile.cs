using System;

namespace Models;

public partial class TblEventFile
{
    public int EventFileId { get; set; }

    public int EventId { get; set; }

    public int FileId { get; set; }

    public bool EventFileDeleted { get; set; }

    public int EventFileCreatedBy { get; set; }

    public DateTime EventFileCreatedDate { get; set; }

    public int? EventFileUpdatedBy { get; set; }

    public DateTime? EventFileUpdatedDate { get; set; }

    public TblEvent Event { get; set; }
    public TblFile File { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
