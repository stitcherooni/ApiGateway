﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblClass
{
    public int ClassId { get; set; }

    public bool ClassIsGroup { get; set; }

    public string ClassName { get; set;}

    public string ClassTeacherName { get; set; }

    public string ClassTeacherTelephone { get; set; }

    public string ClassTeacherEmail { get; set; }

    public string ClassPassword { get; set; }

    public bool? ClassAllowShare { get; set; }

    public ulong ClassAllowParentsEmail { get; set; }

    public bool ClassLowerSchool { get; set; }

    public string ClassFilter { get; set; }

    public bool ClassMailingList { get; set; }

    public int SchoolId { get; set; }

    public int? AcademicYearId { get; set; }

    public int? SchoolYearId { get; set; }

    public bool ClassDeleted { get; set; }
}