using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Organisation
{
    public class SchoolDetailsDTO
    {
        [Required(ErrorMessage = "The School Ptaname is required")]
        public string SchoolPtaname { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress1 { get; set; }
        public string SchoolAddress2 { get; set; }
        public string SchoolTown { get; set; }
        public string SchoolCounty { get; set; }
        public string SchoolPostCode { get; set; }
        public int PlanTypeId { get; set; }
    }
}
