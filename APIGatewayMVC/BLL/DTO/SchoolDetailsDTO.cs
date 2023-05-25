using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class SchoolDetailsDTO
    {
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
