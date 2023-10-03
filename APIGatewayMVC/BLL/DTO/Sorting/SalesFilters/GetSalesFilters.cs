using System.Collections.Generic;

namespace BLL.DTO.Sorting.SalesFilters
{
    public class GetSalesFilters
    {
        public IDictionary<int, IEnumerable<Year>> Year { get; set; }
    }
}
