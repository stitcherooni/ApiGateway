using System;
using System.Collections.Generic;

namespace Models;

public partial class TblTimeZone
{
    public int TimeZoneId { get; set; }

    public string TimeZoneName { get; set;}

    public string TimeZoneDescription { get; set; }

    public decimal? TimeZoneOffset { get; set; }

    public string TimeZoneDateFormat { get; set;}
}
