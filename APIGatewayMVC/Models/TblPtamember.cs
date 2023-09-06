using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPtamember
{
    public int PtamemberId { get; set; }

    public string PtamemberInfo { get; set; }

    public TblSchool School { get; set; }

    public TblRole Role { get; set; }

    public TblCustomer Customer { get; set; }

    public TblAcademicYear AcademicYear { get; set; }

    public bool PtamemberDeleted { get; set; }

    public DateTime PtamemberCreatedDate { get; set; }

    public TblCustomer PtamemberCreatedBy { get; set; }

    public DateTime? PtamemberUpdatedDate { get; set; }

    public TblCustomer PtamemberUpdatedBy { get; set; }
}
