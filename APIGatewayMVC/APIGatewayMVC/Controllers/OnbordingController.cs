using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APIGatewayMVC.Controllers
{
    [ApiController]
    public class OnbordingController : ControllerBase
    {
        private readonly IOnboardingService _dataService;

        public OnbordingController(IOnboardingService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        [Route("api/url")]
        public async Task<IActionResult> UrlAsync([FromBody] CheckUrlRequest urlRequest)
        {
            try
            {
                URLsResponseDTO urlsResponse = new();
                int result = await _dataService.GetEntityCountAsync(urlRequest.Url);
                if (result != 0)
                {
                    urlsResponse.IsValid = false;

                }
                else
                    urlsResponse.IsValid = true;
                urlsResponse.Urls = await _dataService.GenerateUrlsAsync(urlRequest);
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
                await _dataService.OnboardOrganization(onboardingFormDataDTO);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Entity was added");
        }

    }
}