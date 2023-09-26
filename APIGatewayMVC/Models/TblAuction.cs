using System;
using System.Collections.Generic;

namespace Models;

public partial class TblAuction
{
    public int AuctionId { get; set; }

    public string AuctionUuid { get; set; }

    public int EventId { get; set; }

    public string AuctionName { get; set; }

    public int? AuctionOrder { get; set; }

    public string AuctionDescription { get; set; }

    public string AuctionImage { get; set; }

    public decimal AuctionStartPrice { get; set; }

    public decimal AuctionReservePrice { get; set; }

    public decimal? AuctionBuyNowPrice { get; set; }

    public int AuctionStockQty { get; set; }

    public bool? AuctionDisplay { get; set; }

    public bool AuctionSilent { get; set; }

    public bool AuctionHideBidderName { get; set; }

    public bool AuctionHideReserveNotice { get; set; }

    public bool AuctionConcludesAtEvent { get; set; }

    public DateTime AuctionStartDate { get; set; }

    public DateTime? AuctionEndDate { get; set; }

    public bool AuctionDeleted { get; set; }

    public int AuctionCreatedBy { get; set; }

    public DateTime AuctionCreatedDate { get; set; }

    public int? AuctionUpdatedBy { get; set; }

    public DateTime? AuctionUpdatedDate { get; set; }
}
