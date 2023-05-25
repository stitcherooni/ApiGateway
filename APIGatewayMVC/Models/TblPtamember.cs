using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPtamember
{
    public int PtamemberId { get; set; }

    public string PtamemberInfo { get; set; }

    public int SchoolId { get; set; }

    public int RoleId { get; set; }

    public int CustomerId { get; set; }

    public int AcademicYearId { get; set; }

    public bool PtamemberDeleted { get; set; }

    public DateTime PtamemberCreatedDate { get; set; }

    public int? PtamemberCreatedBy { get; set; }

    public DateTime? PtamemberUpdatedDate { get; set; }

    public int? PtamemberUpdatedBy { get; set; }
}
