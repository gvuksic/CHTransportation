using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureDevTesting
{
    public static class GetSystemStatus
    {
        [FunctionName("GetSystemStatus")]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                Route = "systemstatus")
            ] HttpRequest req,
                ILogger log)
        {
            log.LogInformation("HTTP request: get train system status.");

            var json = JsonConvert.SerializeObject(new
            {
                systemStatus = Database.GetSystemStatus()
            });

            return (ActionResult)new OkObjectResult(json);
        }
    }
}
