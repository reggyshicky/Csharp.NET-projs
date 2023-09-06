using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //you can press ctor to create a constructor, we receive options that we have to pass to the base class DbContext
        { 
        }
        //create table
        public DbSet<Category> Categories { get; set; }
    }
}
