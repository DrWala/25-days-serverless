using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace serverless_day1
{
    public static class serverless_day1
    {
        [FunctionName("serverless_day1")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            int rand = new Random().Next(5);
            switch(rand)
            {
                case 1: return new OkObjectResult("נ");
                case 2:
                    return new OkObjectResult("ג");
                case 3:
                    return new OkObjectResult("ה") ;
                case 4:
                    return new OkObjectResult("ש");
            }
            return new BadRequestObjectResult("Well well well...");
        }
    }
}
