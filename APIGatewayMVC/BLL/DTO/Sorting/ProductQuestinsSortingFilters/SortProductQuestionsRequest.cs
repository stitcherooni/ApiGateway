using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Sorting.ProductQuestinsSortingFilters
{
    public class SortProductQuestionsRequest
    {
        public IEnumerable<int> EventIds { get; set; }
        public IEnumerable<int> ProductIds { get; set; }

        [RegularExpression("^(horizontal|vertical)$", ErrorMessage = "Forman must be either 'horizontal' or 'vertical'.")]
        public string GroupBy { get; set; }
    }
}
