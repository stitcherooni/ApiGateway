using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPoll
{
    public int PollId { get; set; }

    public int SchoolId { get; set; }

    public string PollQuestion { get; set;}

    public string PollDescription { get; set;}

    public DateTime? PollStartDate { get; set; }

    public DateTime? PollEndDate { get; set; }

    public string PollImage { get; set; }

    public bool PollDeleted { get; set; }

    public int PollCreatedBy { get; set; }

    public DateTime PollCreatedDate { get; set; }

    public int? PollUpdatedBy { get; set; }

    public DateTime? PollUpdatedDate { get; set; }

    public TblSchool School { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblPollOption> PollOption { get; set; }
}
