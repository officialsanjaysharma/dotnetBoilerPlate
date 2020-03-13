using Microsoft.EntityFrameworkCore;
using dotnetBoilerplate.Models;
namespace Data
{
    public class POCContext : DbContext
    {
        public POCContext(DbContextOptions<POCContext> options) : base(options)
        {
        }

        public DbSet<Book> User { get; set; }
    }
}