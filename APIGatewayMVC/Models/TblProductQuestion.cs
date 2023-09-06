using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductQuestion
{
    public int ProductQuestionId { get; set; }

    public TblProduct Product { get; set; }

    public string ProductQuestionName { get; set;}

    public string ProductQuestionDescription { get; set; }

    public string ProductQuestionImage { get; set; }

    public string ProductQuestionOptions { get; set; }

    public string ProductQuestionDatasource { get; set; }

    public string ProductQuestionType { get; set; }

    public int? ProductQuestionMinLength { get; set; }

    public int? ProductQuestionMaxLength { get; set; }

    public int? ProductQuestionMinValue { get; set; }

    public int? ProductQuestionMaxValue { get; set; }

    public ulong ProductQuestionRequired { get; set; }

    public bool ProductQuestionDisplayOnTicket { get; set; }

    public bool ProductQuestionPreventDuplicates { get; set; }

    public bool ProductQuestionAnswerEncrypted { get; set; }

    public int ProductQuestionOrder { get; set; }

    public ulong ProductQuestionDeleted { get; set; }

    public DateTime ProductQuestionCreatedDate { get; set; }

    public TblCustomer ProductQuestionCreatedBy { get; set; }

    public DateTime? ProductQuestionUpdatedDate { get; set; }

    public TblCustomer ProductQuestionUpdatedBy { get; set; }
}
