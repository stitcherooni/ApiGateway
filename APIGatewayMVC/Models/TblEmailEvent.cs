using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEmailEvent
{
    public int EmailEventId { get; set; }

    public string EmailMailGunId { get; set; }

    public string EmailEvent { get; set; }

    public DateTime? EmailEventTimeStamp { get; set; }

    public string EmailEventRecipient { get; set; }

    public string EmailEventDomain { get; set; }

    public string EmailEventIp { get; set; }

    public string EmailEventCountry { get; set; }

    public string EmailEventRegion { get; set; }

    public string EmailEventCity { get; set; }

    public string EmailEventUserAgent { get; set; }

    public string EmailEventDeviceType { get; set; }

    public string EmailEventClientType { get; set; }

    public string EmailEventClientName { get; set; }

    public string EmailEventClientOs { get; set; }

    public string EmailEventMailingList { get; set; }

    public string EmailEventUrl { get; set; }

    public string EmailEventCode { get; set; }

    public string EmailEventError { get; set; }

    public string EmailEventNotification { get; set; }

    public string EmailEventReason { get; set; }

    public string EmailEventDescription { get; set; }
}
