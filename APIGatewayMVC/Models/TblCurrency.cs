using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCurrency
{
    public int CurrencyId { get; set; }

    public string CurrencyCode { get; set;}

    public string CurrencyIconCode { get; set;}

    public string CurrencyName { get; set;}

    public string CurrencySign { get; set;}

    public bool CurrencyDeleted { get; set; }

    public int CurrencyCreatedBy { get; set; }

    public DateTime CurrencyCreatedDate { get; set; }

    public int? CurrencyUpdatedBy { get; set; }

    public DateTime? CurrencyUpdatedDate { get; set; }

    public List<TblSchool> SchoolPtacurrency { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
