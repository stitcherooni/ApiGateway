using System;

namespace Models;

public partial class TblProductAttribute
{
    public int ProductAttributeId { get; set; }

    public int ProductId { get; set; }

    public string ProductAttributeName { get; set;}

    public string ProductAttributeImage { get; set; }

    public int? ProductAttributeOrder { get; set; }

    public decimal ProductAttributePrice { get; set; }

    public int ProductAttributeStockQty { get; set; }

    public bool? ProductAttributeDisplay { get; set; }

    public DateTime? ProductAttributeSaleStartDate { get; set; }

    public DateTime? ProductAttributeSaleEndDate { get; set; }

    public bool ProductAttributeDeleted { get; set; }

    public int ProductAttributeCreatedBy { get; set; }

    public DateTime ProductAttributeCreatedDate { get; set; }

    public int? ProductAttributeUpdatedBy { get; set; }

    public DateTime? ProductAttributeUpdatedDate { get; set; }

    public TblProduct Product { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
