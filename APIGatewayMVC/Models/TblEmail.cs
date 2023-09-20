using System;

namespace Models;

public partial class TblEmail
{
    public int EmailId { get; set; }

    public int? EmailTemplateId { get; set; }

    public int MessageId { get; set; }

    public string EmailTo { get; set;}

    public string EmailFrom { get; set;}

    public string EmailReplyTo { get; set; }

    public string EmailSubject { get; set;}

    public string EmailBody { get; set;}

    public string EmailAttachment1 { get; set; }

    public string EmailAttachment2 { get; set; }

    public string EmailMailGunId { get; set; }

    public DateTime EmailCreatedDate { get; set; }

    public int EmailCreatedBy { get; set; }

    public DateTime? EmailUpdatedDate { get; set; }

    public int? EmailUpdatedBy { get; set; }

    public bool EmailDeleted { get; set; }

    public TblMessage Message { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
