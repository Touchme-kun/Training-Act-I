using Microsoft.EntityFrameworkCore;

namespace Training_Act_I.Data
{
    public class BookDb : DbContext

    {
        public BookDb(DbContextOptions<BookDb> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
