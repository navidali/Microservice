using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        // class constructor
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }   

        public DbSet<Platform> Platforms { get; set; }

    }
}