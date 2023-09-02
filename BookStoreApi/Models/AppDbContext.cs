using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<SqlBook> Books { get; set; }

    }
}