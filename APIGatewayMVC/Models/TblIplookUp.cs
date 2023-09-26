using System;
using System.Collections.Generic;

namespace Models;

public partial class TblIplookUp
{
    public int IplookUpId { get; set; }

    public string IplookUpIpaddress { get; set;}

    public bool IplookUpBlocked { get; set; }

    public bool IplookUpWhiteListed { get; set; }

    public string IplookUpCountryCode { get; set; }

    public string IplookUpCountryName { get; set; }

    public string IplookUpRegionCode { get; set; }

    public string IplookUpRegionName { get; set; }

    public string IplookUpCity { get; set; }

    public string IplookUpZipCode { get; set; }

    public string IplookUpTimeZone { get; set; }

    public string IplookUpLatitude { get; set; }

    public string IplookUpLongitude { get; set; }

    public DateTime IplookUpCreatedDate { get; set; }

    public DateTime? IplookUpUpdatedDate { get; set; }
}
