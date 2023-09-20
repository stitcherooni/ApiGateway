using System;

namespace Models;

public partial class TblPollAnswer
{
    public int PollAnswerId { get; set; }

    public int PollOptionId { get; set; }

    public string PollAnswerOther { get; set; }

    public int CustomerId { get; set; }

    public bool PollAnswerDeleted { get; set; }

    public int PollAnswerCreatedBy { get; set; }

    public DateTime PollAnswerCreatedDate { get; set; }

    public int? PollAnswerUpdatedBy { get; set; }

    public DateTime? PollAnswerUpdatedDate { get; set; }

    public TblPollOption PollOption { get; set; }
    public TblCustomer Customer { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
