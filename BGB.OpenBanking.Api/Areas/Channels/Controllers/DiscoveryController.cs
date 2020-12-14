using BGB.OpenBanking.Api.Areas.Common.Attributes;
using BGB.OpenBanking.Api.Contracts.Channels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace BGB.OpenBanking.Api.Areas.Channels.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [ApiController]
    public class DiscoveryController : ControllerBase
    {
        /// <summary>
        /// a descrição referente ao código de status retornado pelas APIs
        /// </summary>
        /// <remarks>a descrição referente ao código de status retornado pelas APIs</remarks>
        /// <response code="200">código de status retornado pelas APIs</response>
        [HttpGet]
        [Route("/open-banking/discovery/v1/outage")]
        [ValidateModelState]
        [SwaggerOperation("GetOutage")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseDiscoveryOutageList), description: "código de status retornado pelas APIs")]
        public virtual IActionResult GetOutage()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseDiscoveryOutageList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : [ {\n    \"duration\" : \"PT2H30M\",\n    \"outageTime\" : \"2020-07-21T08:30:00Z\",\n    \"isPartial\" : false,\n    \"explanation\" : \"Atualização do API Gateway\"\n  }, {\n    \"duration\" : \"PT2H30M\",\n    \"outageTime\" : \"2020-07-21T08:30:00Z\",\n    \"isPartial\" : false,\n    \"explanation\" : \"Atualização do API Gateway\"\n  } ],\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\",\n    \"prev\" : \"prev\",\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\"\n  }\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseDiscoveryOutageList>(exampleJson)
            : default(ResponseDiscoveryOutageList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// a descrição referente ao código de status retornado pelas APIs
        /// </summary>
        /// <remarks> descrição referente ao código de status retornado pelas APIs</remarks>
        /// <response code="200">código de status retornado pelas APIs</response>
        [HttpGet]
        [Route("/open-banking/discovery/v1/status")]
        [ValidateModelState]
        [SwaggerOperation("GetStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseDiscoveryStatusList), description: "código de status retornado pelas APIs")]
        public virtual IActionResult GetStatus()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseDiscoveryStatusList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"status\" : [ {\n      \"code\" : \"OK\",\n      \"updateTime\" : \"2020-01-02T01:00:00Z\",\n      \"explanation\" : \"Retorno com Sucesso\",\n      \"expectedResolutionTime\" : \"2020-07-21T08:30:00Z\",\n      \"detectionTime\" : \"2020-07-21T08:30:00Z\"\n    }, {\n      \"code\" : \"OK\",\n      \"updateTime\" : \"2020-01-02T01:00:00Z\",\n      \"explanation\" : \"Retorno com Sucesso\",\n      \"expectedResolutionTime\" : \"2020-07-21T08:30:00Z\",\n      \"detectionTime\" : \"2020-07-21T08:30:00Z\"\n    } ]\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\",\n    \"prev\" : \"prev\",\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\"\n  }\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ResponseDiscoveryStatusList>(exampleJson)
            : default(ResponseDiscoveryStatusList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}