using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureDevTesting
{
    public static class GetTrainAPC
    {
        [FunctionName("GetTrainAPC")]
        public static IActionResult Run(
        [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                Route = "apcdata")
            ] HttpRequest req,
        ILogger log)
        {
            log.LogInformation("HTTP request: get train apc data.");

            var json = JsonConvert.SerializeObject(new
            {
                apcData = Database.GetTrainAPC()
            });

            return (ActionResult)new OkObjectResult(json);
        }
    }
}
