using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBid
{
    public int BidId { get; set; }

    public TblAuction Auction { get; set; }

    public TblCustomer Customer { get; set; }

    public decimal BidAmount { get; set; }

    public DateTime? BidDateTime { get; set; }

    public bool BidDeleted { get; set; }

    public TblCustomer BidCreatedBy { get; set; }

    public DateTime BidCreatedDate { get; set; }

    public TblCustomer BidUpdatedBy { get; set; }

    public DateTime? BidUpdatedDate { get; set; }
}
