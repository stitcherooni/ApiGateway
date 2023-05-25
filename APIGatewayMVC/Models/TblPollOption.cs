using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPollOption
{
    public int PollOptionId { get; set; }

    public int PollId { get; set; }

    public string PollOption { get; set;}

    public bool PollOptionDeleted { get; set; }

    public int PollOptionCreatedBy { get; set; }

    public DateTime PollOptionCreatedDate { get; set; }

    public int PollOptionUpdatedBy { get; set; }

    public DateTime? PollOptionUpdatedDate { get; set; }
}
