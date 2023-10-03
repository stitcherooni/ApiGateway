using System.Collections.Generic;

namespace BLL.DTO.Sorting.EventFilters
{
    public class GetTreasurerEventFilters
    {
        public IDictionary<int, IEnumerable<Year>> Year { get; set; }
        public IEnumerable<PaymentTypes> PaymentTypes { get; set; }

    }
    public class PaymentTypes
    {
        public string PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
    }
}
