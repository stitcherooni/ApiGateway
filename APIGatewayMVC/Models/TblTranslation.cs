using System;
using System.Collections.Generic;

namespace Models;

public partial class TblTranslation
{
    public int TranslationId { get; set; }

    public int ComponentId { get; set; }

    public int ApplicationId { get; set; }

    public int LanguageId { get; set; }

    public string TranslationContent { get; set;}

    public bool TranslationDeleted { get; set; }

    public int TranslationCreatedBy { get; set; }

    public DateTime TranslationCreatedDate { get; set; }

    public int? TranslationUpdatedBy { get; set; }

    public DateTime? TranslationUpdatedDate { get; set; }
}
