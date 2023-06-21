using BLL.DTO;
using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace APIGatewayMVC.Controllers
{
    [ApiController]
    public class OnbordingController : ControllerBase
    {
        private readonly IOnboardingService _onboardingService;
        private readonly IEmailService _emailService;
        private readonly ILogger<OnbordingController> _logger;

        public OnbordingController(IOnboardingService dataService, IEmailService emailService, ILogger<OnbordingController> logger)
        {
            _onboardingService = dataService ?? throw new ArgumentNullException(nameof(dataService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        [Route("api/url")]
        public async Task<IActionResult> UrlAsync([FromBody] CheckUrlRequest urlRequest, CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation($"Processing URL: {urlRequest.Url}");
                URLsResponseDTO urlsResponse = new();
                int result = await _onboardingService.GetEntityCountAsync(urlRequest.Url, cancellationToken);

                if (result != 0)
                {
                    urlsResponse.IsValid = false;
                    _logger.LogWarning($"URL {urlRequest.Url} already exist");
                }
                else
                    urlsResponse.IsValid = true;

                urlsResponse.Urls = await _onboardingService.GenerateUrlsAsync(urlRequest, cancellationToken);
                return Ok(urlsResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error processing URL: {urlRequest.Url}");
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/organization")]
        public async Task<IActionResult> Organization([FromBody] OnboardingFormDataDTO onboardingFormDataDTO, CancellationToken cancellationToken)
        {
            try
            {
                await _onboardingService.OnboardOrganization(onboardingFormDataDTO, cancellationToken);
                _logger.LogInformation("Organization onboarded successfully");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to onboard organization");
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }

            return Ok(new ResponseMessage() { Message = "Entity was added"});
        }

        [HttpPost]
        [Route("api/sendemail")]
        public async Task<IActionResult> SendEmail(string emailAddress, CancellationToken cancellationToken)
        {
            try
            {
                await _emailService.SendEmail(emailAddress, cancellationToken);
                _logger.LogInformation($"Email sent successfully to: {emailAddress}");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to send email to: {emailAddress}");
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
            return Ok(new ResponseMessage() { Message = "Email was sent"});
        }
    }
}
