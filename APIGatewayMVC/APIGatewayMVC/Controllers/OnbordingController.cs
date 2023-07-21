﻿using BLL.DTO;
using BLL.DTO.Organization;
using BLL.DTO.UrlAsync;
using BLL.Services.EmailService;
using BLL.Services.Onboarding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace APIGatewayMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OnbordingController : BaseController
    {
        private readonly IOnboardingService _onboardingService;
        private readonly IEmailService _emailService;
        private readonly ILogger<OnbordingController> _logger;

        public OnbordingController(IOnboardingService dataService,
                                   IEmailService emailService,
                                   ILogger <OnbordingController>logger
                                   )
        {
            _onboardingService = dataService;
            _emailService = emailService;
            _logger = logger;
        }

        [HttpPost]
        [Route("url")]
        public async Task<IActionResult> UrlAsync([FromBody] CheckUrlRequest urlRequest, CancellationToken cancellationToken)
        {
            try
            {
                urlRequest = UrlFilters(urlRequest);
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
                return BadRequest(GenerateErrorMessage(ex, "Can't generate Url"));
            }
        }

        [HttpPost]
        [Route("organisation")]
        public async Task<IActionResult> Organization([FromBody] OnboardingFormDataDTO onboardingFormDataDTO, CancellationToken cancellationToken)
        {
            try
            {
                onboardingFormDataDTO.SchoolBrandingDetails.Url = onboardingFormDataDTO.SchoolBrandingDetails.Url.ToLower();
                if (await _onboardingService.IsUrlFree(onboardingFormDataDTO.SchoolBrandingDetails.Url, cancellationToken))
                {
                    await _onboardingService.OnboardOrganization(onboardingFormDataDTO, cancellationToken);
                    _logger.LogInformation("Organization onboarded successfully");
                }
                else
                    throw new Exception($"Organisation with url {onboardingFormDataDTO.SchoolBrandingDetails.Url} already exist");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to onboard organization");
                return BadRequest(GenerateErrorMessage(ex, "Can't add organisation"));
            }

            return Ok(new { Message = "Organization onboarded successfully" });
        }

        [HttpPost]
        [Route("sendemail")]
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
                return BadRequest(GenerateErrorMessage(ex, $"Can't send email to {emailAddress}"));
            }
            return Ok(new { Message = $"Email sent successfully to: {emailAddress}" });
        }


        private static CheckUrlRequest UrlFilters(CheckUrlRequest urlRequest)
        {
            return new CheckUrlRequest
            {
                Url = UrlFilter(urlRequest.Url),
                PtaName = UrlFilter(urlRequest.PtaName),
                Town = UrlFilter(urlRequest.Town)
            };
        }
        private static string UrlFilter(string text)
        {
            string allowedSymbolsPattern = @"[^a-zA-Z0-9- ]";
            return Regex.Replace(text, allowedSymbolsPattern, "");
        }
    }
}
