using System;
using System.Collections.Generic;

namespace Models;

public partial class TblAcademicYear
{
    public int AcademicYearId { get; set; }

    public string AcademicYearName { get; set;}

    public DateTime? AcademicYearStartDate { get; set; }

    public DateTime? AcademicYearEndDate { get; set; }

    public int CountryId { get; set; }

    public bool AcademicYearDeleted { get; set; }

    public int AcademicYearCreatedBy { get; set; }

    public DateTime AcademicYearCreatedDate { get; set; }

    public int? AcademicYearUpdatedBy { get; set; }

    public DateTime? AcademicYearUpdatedDate { get; set; }

    public TblCountry Country { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblClass> AcademicYearClass { get; set; }
    public List<TblPtamember> AcademicYearPtamember { get; set; }
}
