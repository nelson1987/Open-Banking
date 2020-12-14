using BGB.OpenBanking.Api.Areas.Common.Attributes;
using BGB.OpenBanking.Api.Contracts.Admin;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace BGB.OpenBanking.Api.Areas.Admin.Controllers
{
    [ApiController]
    public class MetricsController : ControllerBase
    {
        [HttpGet]
        [Route("/open-banking/admin/v1/metrics")]
        [ValidateModelState]
        [SwaggerOperation("GetMetrics")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseMetricsList), description: "Dados das métricas")]
        public virtual IActionResult GetMetrics([FromQuery]string period)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseMetricsList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"requestTime\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"rejections\" : {\n      \"previousDays\" : [ 1, 1 ],\n      \"currentDay\" : 7\n    },\n    \"peakTps\" : {\n      \"previousDays\" : [ 3, 3 ],\n      \"currentDay\" : 9\n    },\n    \"averageTps\" : {\n      \"previousDays\" : [ 7, 7 ],\n      \"currentDay\" : 2\n    },\n    \"availability\" : {\n      \"downtime\" : {\n        \"endpoints\" : {\n          \"partialDowntime\" : 1,\n          \"url\" : \"url\"\n        },\n        \"generalDowntime\" : 0,\n        \"scheduledOutage\" : 6\n      },\n      \"uptime\" : {\n        \"generalUptimeRate\" : \"generalUptimeRate\",\n        \"endpoints\" : {\n          \"uptimeRate\" : \"uptimeRate\",\n          \"url\" : \"url\"\n        }\n      }\n    },\n    \"averageResponse\" : { },\n    \"errors\" : {\n      \"previousDays\" : [ 4, 4 ],\n      \"currentDay\" : 2\n    },\n    \"invocations\" : {\n      \"unauthenticated\" : {\n        \"previousDays\" : [ 5, 5 ],\n        \"currentDay\" : 5\n      }\n    }\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"https://api.banco.com.br/open-banking/admin/v1/<resource>\",\n    \"prev\" : \"prev\",\n    \"self\" : \"https://api.banco.com.br/open-banking/admin/v1/<resource>\",\n    \"first\" : \"https://api.banco.com.br/open-banking/admin/v1/<resource>\"\n  }\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseMetricsList>(exampleJson)
            : default(ResponseMetricsList);            //TODO: Change the data returned
            return Ok(example);
        }
    }
}