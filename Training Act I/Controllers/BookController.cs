using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Training_Act_I.Act5_8;
using Training_Act_I.Data;
using Training_Act_I.Migrations;

namespace Training_Act_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly BookDb _context;
        public BookController(BookDb context)
        {
            _context = context;
        }

        //mysql
        [HttpGet("Act4")]
        public async Task<IActionResult> Get()
        {
            var Book = await _context.Books.ToListAsync();
            return Ok(Book);
        }

        [HttpGet("Act5")]
        public async Task<IActionResult> Classlist(int id)
        {

            var Book = await _context.Books.FindAsync(Math.Abs(id));
            if (Book == null)
                return BadRequest("Book not found!");
            return Ok(Book);
            //Book b = new Book();

            //b.Title = ("LOTR");
            //b.Author = ("J.R.R TOLKIENS");
            //b.Genre = ("High Fantasy");
            //b.Summary = ("DaBest");

            return Ok(await _context.Books.ToListAsync());
        }

        [HttpGet("Act6")]
        public async Task<IActionResult> Title(string title)
        {
            var Book = _context.Books.Where(Book => Book.Title.Contains(title));
            if (Book.Count() == 0)
                return BadRequest("Title not found!");
            return Ok(Book);

        }

        [HttpGet("Act7")]
        public async Task<IActionResult> Author(string author)
        {
            var Book = _context.Books.Where(Book => Book.Author.Contains(author));
            if (Book.Count() == 0)
                return BadRequest("Author not found!");
            return Ok(Book);

        }

        [HttpGet("Act8")]
        public async Task<IActionResult> Genre(string genre)
        {
            var Book = _context.Books.Where(Book => Book.Genre == genre);
            if (Book.Count() == 0)
                return BadRequest("Genre not found!");
            return Ok(Book);

        }
    }
}
