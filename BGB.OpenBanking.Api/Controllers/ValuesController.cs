using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BGB.OpenBanking.Api.Controllers
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
}
