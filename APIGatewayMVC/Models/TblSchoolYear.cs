using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSchoolYear
{
    public int SchoolYearId { get; set; }

    public string SchoolYearName { get; set;}

    public int SchoolYearOrder { get; set; }

    public ulong SchoolYearDeleted { get; set; }

    public TblCustomer SchoolYearCreatedBy { get; set; }

    public DateTime SchoolYearCreatedDate { get; set; }

    public TblCustomer SchoolYearUpdatedBy { get; set; }

    public DateTime? SchoolYearUpdatedDate { get; set; }

    public List<TblClass> SchoolYearClass { get; set; }
    public List<TblEventTaskGroup> EventTaskGroup { get; set; }
}
