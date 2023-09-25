using System;

namespace Models;

public partial class TblEventTaskCustomer
{
    public int EventTaskCustomerId { get; set; }

    public int EventTaskId { get; set; }

    public int CustomerId { get; set; }

    public string EventTaskCustomerMessage { get; set; }

    public string EventTaskCustomerFirstName { get; set; }

    public string EventTaskCustomerLastName { get; set; }

    public string EventTaskCustomerEmail { get; set; }

    public string EventTaskCustomerTelephone { get; set; }

    public bool EventTaskCustomerDbschecked { get; set; }

    public bool EventTaskCustomerFirstAider { get; set; }

    public bool EventTaskCustomerDisplayName { get; set; }

    public int EventTaskCustomerCreatedBy { get; set; }

    public DateTime EventTaskCustomerCreatedDate { get; set; }

    public int? EventTaskCustomerUpdatedBy { get; set; }

    public DateTime? EventTaskCustomerUpdatedDate { get; set; }

    public bool EventTaskCustomerDeleted { get; set; }

    public TblEventTask EventTask { get; set; }
    public TblCustomer Customer { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
