using System;
using System.Collections.Generic;

namespace Models;

public partial class TblDiscount
{
    public int DiscountId { get; set; }

    public int SchoolId { get; set; }

    public string DiscountProductIds { get; set; }

    public bool DiscountOrderAllItems { get; set; }

    public int DiscountTypeId { get; set; }

    public string DiscountName { get; set; }

    public decimal? DiscountAmount { get; set; }

    public int? DiscountPercentage { get; set; }

    public int? DiscountPurchaseQty { get; set; }

    public string DiscountCode { get; set; }

    public int? DiscountMaxPurchaseQty { get; set; }

    public int? DiscountMinPurchaseQty { get; set; }

    public int? DiscountEffectiveQty { get; set; }

    public int DiscountDeleted { get; set; }

    public int DiscountCreatedBy { get; set; }

    public DateTime DiscountCreatedDate { get; set; }

    public int? DiscountUpdatedBy { get; set; }

    public DateTime? DiscountUpdatedDate { get; set; }
}
