using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;

namespace BLL.Services.Onboarding
{
    public interface IOnboardingService
    {
        Task<OnboardingEntities> OnboardOrganization(OnboardingFormDataDTO onboardingFormDataDTO, CancellationToken cancellationToken);
        public Task<string[]> GenerateUrlsAsync(CheckUrlRequest urlRequest, CancellationToken cancellationToken);
        public Task<int> GetEntityCountAsync(string key, CancellationToken cancellationToken);
    }
}
