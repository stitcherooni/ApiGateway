using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APIGatewayMVC.Controllers
{
    [ApiController]
    public class OnbordingController : ControllerBase
    {
        private readonly IOnboardingService _onboardingService;
        private readonly IEmailService _emailService;

        public OnbordingController(IOnboardingService dataService, IEmailService emailService)
        {
            _onboardingService = dataService;
            _emailService = emailService;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Index()
        {
            return Ok("success");
        }

        [HttpPost]
        [Route("api/url")]
        public async Task<IActionResult> UrlAsync([FromBody] CheckUrlRequest urlRequest)
        {
            try
            {
                URLsResponseDTO urlsResponse = new();
                int result = await _onboardingService.GetEntityCountAsync(urlRequest.Url);
                if (result != 0)
                {
                    urlsResponse.IsValid = false;

                }
                else
                    urlsResponse.IsValid = true;
                urlsResponse.Urls = await _onboardingService.GenerateUrlsAsync(urlRequest);
                return Ok(urlsResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("api/organization")]
        public async Task<IActionResult> Organization([FromBody] OnboardingFormDataDTO onboardingFormDataDTO)
        {
            try
            {
                await _onboardingService.OnboardOrganization(onboardingFormDataDTO);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Entity was added");
        }

        [HttpPost]
        [Route("api/sendemail")]
        public async Task<IActionResult> SendEmail(string emailAdress)
        {
            try
            {
                await _emailService.SendEmail(emailAdress);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok("Email was sent");
        }

    }

}
