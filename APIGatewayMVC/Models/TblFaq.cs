using System;
using System.Collections.Generic;

namespace Models;

public partial class TblFaq
{
    public int FaqId { get; set; }

    public string FaqTitle { get; set;}

    public string FaqText { get; set; }

    public DateTime? FaqStartDate { get; set; }

    public DateTime? FaqEndDate { get; set; }

    public int? FaqSortOrder { get; set; }

    public int SchoolId { get; set; }

    public bool FaqDeleted { get; set; }

    public int FaqCreatedBy { get; set; }

    public DateTime FaqCreatedDate { get; set; }

    public int? FaqUpdatedBy { get; set; }

    public DateTime? FaqUpdatedDate { get; set; }

    public TblSchool School { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
