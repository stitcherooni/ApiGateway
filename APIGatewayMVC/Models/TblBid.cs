using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBid
{
    public int BidId { get; set; }

    public int AuctionId { get; set; }

    public int CustomerId { get; set; }

    public decimal BidAmount { get; set; }

    public DateTime? BidDateTime { get; set; }

    public bool BidDeleted { get; set; }

    public int BidCreatedBy { get; set; }

    public DateTime BidCreatedDate { get; set; }

    public int? BidUpdatedBy { get; set; }

    public DateTime? BidUpdatedDate { get; set; }
}
