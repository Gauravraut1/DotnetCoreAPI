using Microsoft.EntityFrameworkCore;
using DotnetCoreApipractice.Models;

namespace DotnetCoreApipractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Fruit> Fruits { get; set; }
    }
}
