using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPollAnswer
{
    public int PollAnswerId { get; set; }

    public TblPollOption PollOption { get; set; }

    public string PollAnswerOther { get; set; }

    public TblCustomer Customer { get; set; }

    public bool PollAnswerDeleted { get; set; }

    public TblCustomer PollAnswerCreatedBy { get; set; }

    public DateTime PollAnswerCreatedDate { get; set; }

    public TblCustomer PollAnswerUpdatedBy { get; set; }

    public DateTime? PollAnswerUpdatedDate { get; set; }
}
