using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Training_Act_I.Act2;

namespace Training_Act_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Act2")]
        [Produces("application/xml")]
        public async Task<ActionResult<Prime>> Get()
        {
            Prime prime = new Prime();
              string[] last = { "Hello", "Hi", "Hey", "hehe" };
              string displayLast = last[last.Length - 1];
            // string displayLast = "POTANF INA";
            prime.Last = displayLast;
            return Ok(prime);
        }
    }
}
