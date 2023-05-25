using System;
using System.Collections.Generic;

namespace Models;

public partial class TblNews
{
    public int NewsId { get; set; }

    public string NewsTitle { get; set;}

    public string NewsTeaser { get; set; }

    public string NewsImage { get; set; }

    public string NewsText { get; set; }

    public DateTime? NewsStartDate { get; set; }

    public DateTime? NewsEndDate { get; set; }

    public bool? NewsShowTime { get; set; }

    public int SchoolId { get; set; }

    public bool NewsDeleted { get; set; }

    public int NewsCreatedBy { get; set; }

    public DateTime NewsCreatedDate { get; set; }

    public int? NewsUpdatedBy { get; set; }

    public DateTime? NewsUpdatedDate { get; set; }
}
