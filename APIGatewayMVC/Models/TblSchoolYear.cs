using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSchoolYear
{
    public int SchoolYearId { get; set; }

    public string SchoolYearName { get; set;}

    public int SchoolYearOrder { get; set; }

    public ulong SchoolYearDeleted { get; set; }

    public int SchoolYearCreatedBy { get; set; }

    public DateTime SchoolYearCreatedDate { get; set; }

    public int? SchoolYearUpdatedBy { get; set; }

    public DateTime? SchoolYearUpdatedDate { get; set; }
}
