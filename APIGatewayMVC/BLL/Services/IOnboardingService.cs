using BLL.DTO;

namespace BLL.Services
{
    public interface IOnboardingService
    {
        Task OnboardOrganization(OnboardingFormDataDTO onboardingFormDataDTO);
        public Task<string[]> GenerateUrlsAsync(CheckUrlRequest urlRequest);
        public Task<int> GetEntityCountAsync(string key);
    }
}
