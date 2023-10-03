using System.Collections.Generic;

namespace BLL.DTO.Sorting.TicketFilters
{
    public class TicketFilters
    {
        public IDictionary<int, IEnumerable<Year>> Year { get; set; }
        public IEnumerable<Filters> Filters { get; set; }

    }
    public class Filters
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
    }
}
