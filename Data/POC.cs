using UserApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class POCContext : DbContext
    {
        public POCContext(DbContextOptions<POCContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}