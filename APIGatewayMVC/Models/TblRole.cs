using System;
using System.Collections.Generic;

namespace Models;

public partial class TblRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set;}

    public int RoleSortOrder { get; set; }

    public string RoleCode { get; set;}

    public string RoleDescription { get; set; }

    public bool RoleCommittee { get; set; }

    public bool RoleDeleted { get; set; }

    public int RoleCreatedBy { get; set; }

    public DateTime RoleCreatedDate { get; set; }

    public int? RoleUpdatedBy { get; set; }

    public DateTime? RoleUpdatedDate { get; set; }
}
