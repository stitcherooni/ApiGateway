using System;

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

    public TblSchool School { get; set; }
    public TblRole Role { get; set; }
    public TblAcademicYear AcademicYear { get; set; }
    public TblCustomer Customer { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
