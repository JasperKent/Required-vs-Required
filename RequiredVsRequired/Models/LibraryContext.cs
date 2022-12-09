using Microsoft.EntityFrameworkCore;

namespace RequiredVsRequired.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
