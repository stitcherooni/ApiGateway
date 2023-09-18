using System;
using System.Collections.Generic;

namespace Models;

public partial class TblMessage
{
    public int MessageId { get; set; }

    public TblMessageGroup MessageGroup { get; set; }

    public int MessageTypeId { get; set; }

    public string MessageTitle { get; set;}

    public string MessageTeaser { get; set; }

    public string MessageText { get; set; }

    public TblCustomer Customer { get; set; }

    public string MessageCustomerName { get; set; }

    public string MessageCustomerEmail { get; set; }

    public string MessageMailGunId { get; set; }

    public DateTime MessageCreatedDate { get; set; }

    public TblCustomer MessageCreatedBy { get; set; }

    public DateTime? MessageUpdatedDate { get; set; }

    public TblCustomer MessageUpdatedBy { get; set; }

    public bool MessageDeleted { get; set; }

    public bool MessageSent { get; set; }

    public string MessageAttachment1 { get; set; }

    public string MessageAttachment2 { get; set; }

    public List<TblEmail> EmailMessage { get; set; }
}
