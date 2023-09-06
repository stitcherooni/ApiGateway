using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductQuestionAnswer
{
    public int ProductQuestionAnswerId { get; set; }

    public int? BookingNo { get; set; }

    public TblCustomer ProductQuestion { get; set; }

    public int OrderItemId { get; set; }

    public string ProductQuestionAnswer { get; set;}

    public ulong ProductQuestionAnswerDeleted { get; set; }

    public DateTime ProductQuestionAnswerCreatedDate { get; set; }

    public TblCustomer ProductQuestionAnswerCreatedBy { get; set; }

    public DateTime? ProductQuestionAnswerUpdatedDate { get; set; }

    public TblCustomer ProductQuestionAnswerUpdatedBy { get; set; }
}
