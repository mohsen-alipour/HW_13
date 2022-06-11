using Microsoft.EntityFrameworkCore;
using WebApp_HW_13.Models.Entity;
namespace WebApp_HW_13.infrastructure.DataBase
{
    public class LibararyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = HW13; User Id = sa; Password = 123456;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Librarys { get; set; }
        public DbSet<BookLibarary> BookLibararys { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Amanat> Amanats { get; set; }


    }
}
