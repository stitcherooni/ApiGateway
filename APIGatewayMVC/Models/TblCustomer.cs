using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public bool CustomerGuest { get; set; }

    public string CustomerPartnerId { get; set; }

    public int? LegacyCustomerId { get; set; }

    public int ApplicationId { get; set; }

    public int Ptaid { get; set; }

    public string CustomerUuid { get; set; }

    public string CustomerTitle { get; set; }

    public string CustomerFirstName { get; set;}

    public string CustomerLastName { get; set;}

    public string CustomerAddress1 { get; set; }

    public string CustomerAddress2 { get; set; }

    public string CustomerTown { get; set; }

    public string CustomerCounty { get; set; }

    public string CustomerPostCode { get; set; }

    public string CustomerEmail { get; set;}

    public string CustomerPassword { get; set;}

    public string CustomerSalt { get; set; }

    public string CustomerHashId { get; set; }

    public string CustomerPasswordReset { get; set; }

    public DateTime? CustomerPasswordResetDate { get; set; }

    public DateTime? CustomerLastLoginDateTime { get; set; }

    public int? CustomerLoginAttempts { get; set; }

    public DateTime? CustomerLastLoginAttemptDate { get; set; }

    public DateTime? CustomerLastLoginDate { get; set; }

    public string CustomerTelephone { get; set; }

    public string CustomerMobile { get; set; }

    public string CustomerStripeTestId { get; set; }

    public string CustomerStripeLiveId { get; set; }

    public string CustomerQflowPassword { get; set; }

    public string CustomerGeneric1 { get; set; }

    public string CustomerGeneric2 { get; set; }

    public string CustomerGeneric3 { get; set; }

    public int? CustomerSchoolId { get; set; }

    public string CustomerSchoolClass { get; set; }

    public bool? CustomerMarketingEmails { get; set; }

    public bool? CustomerPlatformArchiveReminderEmails { get; set; }

    public bool CustomerNewsLetter { get; set; }

    public DateTime? CustomerGiftAidDeclarationDate { get; set; }

    public bool CustomerDbschecked { get; set; }

    public bool CustomerFirstAider { get; set; }

    public bool? CustomerConfirmed { get; set; }

    public bool? CustomerApproved { get; set; }

    public string CustomerGoCardlessLiveMandate { get; set; }

    public string CustomerGoCardlessTestMandate { get; set; }

    public bool CustomerTerms { get; set; }

    public bool CustomerGdprconsentSent { get; set; }

    public bool? CustomerVerified { get; set; }

    public bool CustomerDeleted { get; set; }

    public DateTime? CustomerErasureDate { get; set; }

    public bool CustomerErased { get; set; }

    public DateTime CustomerCreatedDate { get; set; }

    public int CustomerCreatedBy { get; set; }

    public DateTime? CustomerUpdatedDate { get; set; }

    public int? CustomerUpdatedBy { get; set; }
}
