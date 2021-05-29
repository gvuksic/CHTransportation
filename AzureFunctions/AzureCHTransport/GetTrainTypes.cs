using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureDevTesting
{
    public static class GetTrainTypes
    {
        [FunctionName("GetTrainTypes")]
        public static IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                Route = "types")
            ] HttpRequest req,
                ILogger log)
        {
            log.LogInformation("HTTP request: get train types.");

            var json = JsonConvert.SerializeObject(new
            {
                users = Database.GetTrainTypes()
            });

            return (ActionResult)new OkObjectResult(json);
        }

    }
}
