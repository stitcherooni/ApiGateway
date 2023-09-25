using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCountry
{
    public int CountryId { get; set; }

    public string CountryCode { get; set;}

    public string CountryName { get; set;}

    public string CountryDateFormat { get; set; }

    public bool CountryDeleted { get; set; }

    public int CountryCreatedBy { get; set; }

    public DateTime CountryCreatedDate { get; set; }

    public int? CountryUpdatedBy { get; set; }

    public DateTime? CountryUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblSchool> SchoolsPtacountry { get; set; }
    public List<TblAcademicYear> AcademicCountry{ get; set; }
    public List<TblSponsor> SponsorCountry { get; set; }
}
