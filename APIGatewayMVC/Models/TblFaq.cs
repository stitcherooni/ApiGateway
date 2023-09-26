using System;
using System.Collections.Generic;

namespace Models;

public partial class TblFaq
{
    public int Faqid { get; set; }

    public string Faqtitle { get; set; }

    public string Faqtext { get; set; }

    public DateTime? FaqstartDate { get; set; }

    public DateTime? FaqendDate { get; set; }

    public int? FaqsortOrder { get; set; }

    public int SchoolId { get; set; }

    public bool Faqdeleted { get; set; }

    public int FaqcreatedBy { get; set; }

    public DateTime FaqcreatedDate { get; set; }

    public int? FaqupdatedBy { get; set; }

    public DateTime? FaqupdatedDate { get; set; }
}
