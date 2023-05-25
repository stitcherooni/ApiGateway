using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPage
{
    public int PageId { get; set; }

    public bool GlobalPage { get; set; }

    public string PageName { get; set;}

    public DateTime? PageStartDate { get; set; }

    public DateTime? PageEndDate { get; set; }

    public string PageContent { get; set;}

    public int SchoolId { get; set; }

    public bool PageDeleted { get; set; }

    public int PageCreatedBy { get; set; }

    public DateTime PageCreatedDate { get; set; }

    public int? PageUpdatedBy { get; set; }

    public DateTime? PageUpdatedDate { get; set; }
}
