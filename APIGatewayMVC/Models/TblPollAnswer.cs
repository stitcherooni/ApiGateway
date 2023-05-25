﻿using System;
using System.Collections.Generic;

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

    public int PollAnswerUpdatedBy { get; set; }

    public DateTime? PollAnswerUpdatedDate { get; set; }
}
