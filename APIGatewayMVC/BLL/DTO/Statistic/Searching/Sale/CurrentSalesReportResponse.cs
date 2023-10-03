using BLL.DTO.Statistic.Reports.Sale;
using System.Collections.Generic;

public class CurrentSalesReportResponse
{
    public Dictionary<string, SoldItem> SoldValue { get; set; }
}
