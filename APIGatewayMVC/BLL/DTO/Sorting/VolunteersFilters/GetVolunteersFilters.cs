namespace BLL.DTO.Sorting.VolunteersFilters
{
    public class GetVolunteersFilters
    {
        public IDictionary<int, IEnumerable<Year>> Year { get; set; }
        public IEnumerable<GroupBy> GroupBy { get; set; }
    }
}
