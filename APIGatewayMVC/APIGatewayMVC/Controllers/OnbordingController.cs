using BLL.DTO;
using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using Microsoft.AspNetCore.Mvc;
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

        public OnbordingController(IOnboardingService dataService, IEmailService emailService)
        {
            _onboardingService = dataService;
            _emailService = emailService;
        }

        [HttpPost]
        [Route("api/url")]
        public async Task<IActionResult> UrlAsync([FromBody] CheckUrlRequest urlRequest, CancellationToken cancellationToken)
        {
            try
            {
                URLsResponseDTO urlsResponse = new();
                int result = await _onboardingService.GetEntityCountAsync(urlRequest.Url, cancellationToken);
                if (result != 0)
                {
                    urlsResponse.IsValid = false;
                }
                else
                    urlsResponse.IsValid = true;
                urlsResponse.Urls = await _onboardingService.GenerateUrlsAsync(urlRequest, cancellationToken);
                return Ok(urlsResponse);
            }
            catch (Exception ex)
            {
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
            }

            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message=ex.Message});
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
            }

            catch (Exception ex)
            {
                return BadRequest(new ResponseMessage() { Message = ex.Message });
            }
            return Ok(new ResponseMessage() { Message = "Email was sent"});
        }
    }
}
