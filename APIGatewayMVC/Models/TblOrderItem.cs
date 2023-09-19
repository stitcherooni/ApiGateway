using System;
using System.Collections.Generic;

namespace Models;

public partial class TblOrderItem
{
    public int OrderItemId { get; set; }

    public int? LegacyOrderItemId { get; set; }

    public int OrderId { get; set; }
          
    public int ItemId { get; set; }

    public int ProductPaymentSchemeId { get; set; }

    public string OrderItemName { get; set; }

    public int OrderItemQty { get; set; }

    public decimal OrderItemPrice { get; set; }

    public decimal OrderItemLinePrice { get; set; }

    public bool? OrderItemReserved { get; set; }

    public DateTime? OrderItemReservedDate { get; set; }

    public bool OrderItemCompleted { get; set; }

    public bool? OrderItemDespatched { get; set; }

    public bool OrderItemRefunded { get; set; }

    public int OrderItemRefundQty { get; set; }

    public decimal OrderItemRefundValue { get; set; }

    public bool OrderItemDeleted { get; set; }

    public bool OrderItemTest { get; set; }

    public int OrderItemCreatedBy { get; set; }

    public DateTime OrderItemCreatedDate { get; set; }

    public int? OrderItemUpdatedBy { get; set; }

    public DateTime? OrderItemUpdatedDate { get; set; }

    public List<TblBooking> BookingOrderItem { get; set; }

    public TblCustomer Order { get; set; }
    public TblCustomer Item { get; set; }
    public TblCustomer ProductPaymentScheme { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
