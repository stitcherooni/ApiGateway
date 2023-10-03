using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Sorting.ProductQuestionsSortingFilters
{
    public class GetProductQuestionsSortingFilters
    {
        public IEnumerable<Events> Events { get; set; }
        public IEnumerable<Products> Products { get; set; }

        [RegularExpression("^(horizontal|vertical)$", ErrorMessage = "Forman must be either 'horizontal' or 'vertical'.")]
        public string Format { get; set; }

    }
}
