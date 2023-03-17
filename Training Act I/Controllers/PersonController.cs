using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Training_Act_I.Models;

namespace Training_Act_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //[HttpGet]
        // public async Task<IActionResult> Get()
        // {
        //     Person person = new Person();
        //     foreach (string item in person.Name) { Console.WriteLine(item); }

        //     return Ok(person.Name);

        // }

        public string[] Person = {
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
   
       
    }
}
