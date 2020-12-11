using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BGB.OpenBanking.Areas.Admin.Controllers
{
    [EnableCors("DefaultPolicy")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Authorize("Bearer")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST api/values/5
        [HttpPost("{id}")]
        [ProducesResponseType(200)]//, Type = typeof(IList<Chanel>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [ProducesResponseType(405)]
        [ProducesResponseType(406)]
        [ProducesResponseType(410)]
        [ProducesResponseType(415)]
        [ProducesResponseType(422)]
        [ProducesResponseType(429)]
        [ProducesResponseType(500)]
        [ProducesResponseType(503)]
        [ProducesResponseType(504)]
        public IActionResult Post(int id)
        {
            return Ok("value");
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]//, Type = typeof(IList<Chanel>))]
        [ProducesResponseType(201)]//, Type = typeof(IList<Chanel>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [ProducesResponseType(405)]
        [ProducesResponseType(406)]
        [ProducesResponseType(410)]
        [ProducesResponseType(422)]
        [ProducesResponseType(429)]
        [ProducesResponseType(500)]
        [ProducesResponseType(503)]
        [ProducesResponseType(504)]
        public IActionResult Get()
        {
            //Response.Headers.Add("X-Total-Count", list.Count.ToString());
            return Ok(new string[] { "value1", "value2" });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]//, Type = typeof(IList<Chanel>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [ProducesResponseType(405)]
        [ProducesResponseType(406)]
        [ProducesResponseType(410)]
        [ProducesResponseType(429)]
        [ProducesResponseType(500)]
        [ProducesResponseType(503)]
        [ProducesResponseType(504)]
        public IActionResult Delete(int id)
        {
            return Ok("value");
        }
    }

    /*
     * open-banking/discovery/v1/status
     */

    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class OutagesController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ChannelsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult ListarDependenciasProprias(int id)
        {
            return Ok("value");
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult ListarCanaisAtendimentoEletronicos(int id)
        {
            return Ok("value");
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult ListarCanaisAtendimentoTelefonicos(int id)
        {
            return Ok("value");
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult ListarTerminaisAutoAtendimentoCompartilhados(int id)
        {
            return Ok("value");
        }
    }
}