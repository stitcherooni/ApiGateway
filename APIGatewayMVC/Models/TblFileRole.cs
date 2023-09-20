using System;

namespace Models;

public partial class TblFileRole
{
    public int FileRoleId { get; set; }

    public int FileId { get; set; }

    public int RoleId { get; set; }

    public bool FileRoleDeleted { get; set; }

    public DateTime FileRoleCreatedDate { get; set; }

    public int FileRoleCreatedBy { get; set; }

    public DateTime? FileRoleUpdatedDate { get; set; }

    public int? FileRoleUpdatedBy { get; set; }

    public TblFile File { get; set; }
    public TblRole Role { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
