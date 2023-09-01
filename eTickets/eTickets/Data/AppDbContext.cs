using Microsoft.EntityFrameworkCore;
using  eTickets.Models;
namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Actor_Movie>().HasKey(am => )
            base.OnModelCreating(modelBuilder);
        }
    }
}
