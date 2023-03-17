using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Training_Act_I.Models;

namespace Training_Act_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("Act1")]
        public async Task<IActionResult> Person()
        {
            string[] personName =
            {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "15th"
            };

            Trainee t1 = new Trainee(personName[0]);
            Trainee t2 = new Trainee(personName[1]);
            Trainer tner = new Trainer(personName[2]);

            Console.WriteLine(t1.Study());
            Console.WriteLine(t2.Study());
            Console.WriteLine(tner.Explain());

            return Ok(personName);
        }

    
    }
}
