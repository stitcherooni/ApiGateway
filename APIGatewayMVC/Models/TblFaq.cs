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

    public TblSchool School { get; set; }

    public bool FaqDeleted { get; set; }

    public TblCustomer FaqCreatedBy { get; set; }

    public DateTime FaqCreatedDate { get; set; }

    public TblCustomer FaqUpdatedBy { get; set; }

    public DateTime? FaqUpdatedDate { get; set; }
}
