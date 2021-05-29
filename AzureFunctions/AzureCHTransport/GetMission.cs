using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureDevTesting
{
    public static class GetMission
    {
        [FunctionName("GetMission")]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                Route = "mission")
            ] HttpRequest req,
                ILogger log)
        {
            log.LogInformation("HTTP request: get train mission.");

            var json = JsonConvert.SerializeObject(new
            {
                mission = Database.GetMission()
            });

            return (ActionResult)new OkObjectResult(json);
        }
    }
}
