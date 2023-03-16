using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using Training_Act_I.Act3;
using Training_Act_I.Models;

namespace Training_Act_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeController : ControllerBase
    {
        [HttpGet("YearAge")]
        public async Task<IActionResult> Get(int Year)
        {
            Age a = new Age();
            a.AgeYear = Math.Abs(Year);

            return Ok(a.ageLength(Year));


        }
    }
}
