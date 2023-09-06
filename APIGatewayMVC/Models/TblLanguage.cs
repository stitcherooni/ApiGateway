using System;
using System.Collections.Generic;

namespace Models;

public partial class TblLanguage
{
    public int LanguageId { get; set; }

    public string LanguageCode { get; set;}

    public string LanguageName { get; set;}

    public bool LanguageDeleted { get; set; }

    public TblCustomer LanguageCreatedBy { get; set; }

    public DateTime LanguageCreatedDate { get; set; }

    public TblCustomer LanguageUpdatedBy { get; set; }

    public DateTime? LanguageUpdatedDate { get; set; }
}
