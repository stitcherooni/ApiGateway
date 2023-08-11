using System;

namespace BLL.DTO.Statistic.Reports.MiWizard
{
    public class MiWizardDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string EventName { get; set; }
        public string PtaName { get; set; }
        public int Pupils { get; set; }
        public DateTime Date { get; set; }
        public int Orders { get; set; }
        public TotalDTO Value { get; set; }
    }
}
