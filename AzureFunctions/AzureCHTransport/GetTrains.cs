using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureDevTesting
{
    public static class GetTrains
    {
        [FunctionName("GetTrains")]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                Route = "trains")
            ] HttpRequest req,
                ILogger log)
        {
            log.LogInformation("HTTP request: get trains.");

            var json = JsonConvert.SerializeObject(new
            {
                trains = Database.GetTrains()
            });

            return (ActionResult)new OkObjectResult(json);
        }

    }
}
