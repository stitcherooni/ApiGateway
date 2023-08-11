using BLL.DTO.Organisation;
using BLL.DTO.UrlAsync;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Services.Onboarding
{
    public interface IOnboardingService
    {
        Task<OnboardingEntities> OnboardOrganisation(OnboardingFormDataDTO onboardingFormDataDTO, CancellationToken cancellationToken);
        public Task<IEnumerable<string>> GenerateUrlsAsync(CheckUrlRequest urlRequest, CancellationToken cancellationToken);
        public Task<int> GetEntityCountAsync(string key, CancellationToken cancellationToken);
        public Task<bool> IsUrlFree(string url, CancellationToken cancellationToken);
    }
}
