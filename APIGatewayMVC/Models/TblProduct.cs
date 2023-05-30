﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public int? LegacyProductId { get; set; }

    public int? SubGroupId { get; set; }

    public int SchoolId { get; set; }

    public int? AuctionId { get; set; }

    public string ProductName { get; set;}

    public string ProductTime { get; set; }

    public string ProductImage { get; set; }

    public int? ProductOrder { get; set; }

    public int ProductTypeId { get; set; }

    public string ProductDescription { get; set;}

    public string ProductEmailText { get; set; }

    public string ProductRequiredInformation { get; set; }

    public string ProductSku { get; set;}

    public decimal ProductPrice { get; set; }

    public decimal ProductCost { get; set; }

    public decimal? ProductMinPrice { get; set; }

    public int ProductQty { get; set; }

    public bool ProductIncludeInEventMaxAttendees { get; set; }

    public int ProductStockQty { get; set; }

    public int ProductTargetQty { get; set; }

    public int? ProductMaxQty { get; set; }

    public int? ProductMinQty { get; set; }

    public bool? ProductDisplayStockQty { get; set; }

    public bool? ProductDisplay { get; set; }

    public DateTime? ProductSaleStartDate { get; set; }

    public DateTime? ProductSaleEndDate { get; set; }

    public bool ProductBookable { get; set; }

    public bool ProductDisplayQtySold { get; set; }

    public bool ProductHideClass { get; set; }

    public bool ProductShowClassOnTicket { get; set; }

    public string ProductBookingLabel { get; set; }

    public int ProductComplimentaryFor { get; set; }

    public bool ProductPayOnCollection { get; set; }

    public bool ProductDeleted { get; set; }

    public int ProductCreatedBy { get; set; }

    public DateTime ProductCreatedDate { get; set; }

    public int? ProductUpdatedBy { get; set; }

    public DateTime? ProductUpdatedDate { get; set; }
}