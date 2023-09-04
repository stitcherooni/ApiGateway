using System;

namespace Models;

public partial class TblAcademicYear
{
    public int AcademicYearId { get; set; }

    public string AcademicYearName { get; set;}

    public DateTime? AcademicYearStartDate { get; set; }

    public DateTime? AcademicYearEndDate { get; set; }

    public TblCountry Country { get; set; }

    public bool AcademicYearDeleted { get; set; }

    public TblCustomer AcademicYearCreatedBy { get; set; }

    public DateTime AcademicYearCreatedDate { get; set; }

    public TblCustomer AcademicYearUpdatedBy { get; set; }

    public DateTime? AcademicYearUpdatedDate { get; set; }
}
