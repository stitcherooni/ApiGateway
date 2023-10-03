using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.MiWizard
{
    public class GetMiWizardsReportsResponse
    {
        public IEnumerable<MiWizardDTO> Data { get; set; }
    }
}
