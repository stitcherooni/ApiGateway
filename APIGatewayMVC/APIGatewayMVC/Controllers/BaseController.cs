using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using BLL.DTO;
using System.Collections.Generic;
using BLL.DTO.UrlAsync;
using System.Text.RegularExpressions;

namespace APIGatewayMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {

        [ApiExplorerSettings(IgnoreApi = true)]
        public ErrorResponseMessage GenerateErrorMessage(Exception ex, string title)
        {
            string stackTrace = ex.StackTrace;
            int methodStartIndex = stackTrace.IndexOf("at ") + 3;
            int methodEndIndex = stackTrace.IndexOf("(");
            string methodName = stackTrace.Substring(methodStartIndex, methodEndIndex - methodStartIndex);

            var traceId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;

            return new ErrorResponseMessage
            {
                Type = ex.GetType().ToString(),
                Title = title,
                Status = 400,
                TraceId = traceId,
                Errors = new Dictionary<string, List<string>>
                {
                    { methodName, new List<string>
                        {
                            ex.Message
                        }
                    }
                }
            };
        }
    }
}
