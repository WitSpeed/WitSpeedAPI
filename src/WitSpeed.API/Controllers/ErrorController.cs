using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WitSpeed.API.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;
        private static string errPath, errString = "";
        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [Route("/Error/{statusCode}")]
        public IActionResult PageNotFoundHandler(int statusCode)
        {
            var statusDetails = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    statusDetails = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                    errPath = statusDetails.OriginalPath;
                    errString = statusDetails.OriginalQueryString;
                    _logger.LogError($"{errPath}, {errString}");
                    return RedirectToAction("Error", new { message = "You seem lost, are you?", statusCode = 404 });

                case 403:
                    statusDetails = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                    errPath = statusDetails.OriginalPath;
                    errString = statusDetails.OriginalQueryString;
                    _logger.LogError($"{errPath}, {errString}");
                    return RedirectToAction("Error", new { message = "Access Denied", statusCode = 403 });

                case 500:
                    statusDetails = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                    errPath = statusDetails.OriginalPath;
                    errString = statusDetails.OriginalQueryString;
                    _logger.LogError($"{errPath}, {errString}");
                    return RedirectToAction("Error", new { message = "Sorry, something went wrong. We are working on it", statusCode = 500 });

                case 401:
                    statusDetails = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                    errPath = statusDetails.OriginalPath;
                    errString = statusDetails.OriginalQueryString;
                    _logger.LogError($"{errPath}, {errString}");
                    return RedirectToAction("Error", new { message = "Unauthorized", statusCode = 401 });

                default:
                    statusDetails = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                    errPath = statusDetails.OriginalPath;
                    errString = statusDetails.OriginalQueryString;
                    _logger.LogError($"{errPath}, {errString}");
                    return RedirectToAction("Error", new { message = "You're probably looking for somewhere else.", statusCode = 302 });

            }
        }

        [HttpGet]
        public IActionResult Error(string message, int statusCode)
        {
            ViewBag.Message = message;
            ViewBag.StatusCode = statusCode;
            return View();
        }
    }
}
