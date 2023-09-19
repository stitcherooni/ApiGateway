using System;
using System.Collections.Generic;

namespace Models;

public partial class TblLanguage
{
    public int LanguageId { get; set; }

    public string LanguageCode { get; set;}

    public string LanguageName { get; set;}

    public bool LanguageDeleted { get; set; }

    public int LanguageCreatedBy { get; set; }

    public DateTime LanguageCreatedDate { get; set; }

    public int? LanguageUpdatedBy { get; set; }

    public DateTime? LanguageUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
