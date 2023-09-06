using System;
using System.Collections.Generic;

namespace Models;

public partial class TblFileRole
{
    public int FileRoleId { get; set; }

    public TblFile File { get; set; }

    public TblRole Role { get; set; }

    public bool FileRoleDeleted { get; set; }

    public DateTime FileRoleCreatedDate { get; set; }

    public TblCustomer FileRoleCreatedBy { get; set; }

    public DateTime? FileRoleUpdatedDate { get; set; }

    public TblCustomer FileRoleUpdatedBy { get; set; }
}
