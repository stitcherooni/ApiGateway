using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPollOption
{
    public int PollOptionId { get; set; }

    public TblPoll Poll { get; set; }

    public string PollOption { get; set;}

    public bool PollOptionDeleted { get; set; }

    public TblCustomer PollOptionCreatedBy { get; set; }

    public DateTime PollOptionCreatedDate { get; set; }

    public TblCustomer PollOptionUpdatedBy { get; set; }

    public DateTime? PollOptionUpdatedDate { get; set; }
}
