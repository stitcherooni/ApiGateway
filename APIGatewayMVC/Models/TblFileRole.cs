using System;
using System.Collections.Generic;

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
}
