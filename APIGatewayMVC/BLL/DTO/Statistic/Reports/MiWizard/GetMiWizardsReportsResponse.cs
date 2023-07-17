namespace BLL.DTO.Statistic.Reports.MiWizard
{
    public class GetMiWizardsReportsResponse: PagesInfoDTO
    {
        public IEnumerable<MiWizardDTO> Data { get; set; }
    }
}
