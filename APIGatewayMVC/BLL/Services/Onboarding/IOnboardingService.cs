using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;

namespace BLL.Services.Onboarding
{
    public interface IOnboardingService
    {
        Task OnboardOrganization(OnboardingFormDataDTO onboardingFormDataDTO);
        public Task<string[]> GenerateUrlsAsync(CheckUrlRequest urlRequest);
        public Task<int> GetEntityCountAsync(string key);
    }
}
