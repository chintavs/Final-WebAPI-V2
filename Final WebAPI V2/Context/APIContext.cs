using Final_WebAPI_V2.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_WebAPI_V2.Context
{

    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
