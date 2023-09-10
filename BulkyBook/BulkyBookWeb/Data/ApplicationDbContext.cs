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
/*
 * ApplicationDbContex is a class that manages the connection to your application's database.
It's responsible for interacting with the database, executing queries, and performing
operations like reading, writing, and updating data.
he constructor of ApplicationDbContext takes an DbContextOptions<ApplicationDbContext> parameter.
This parameter is typically provided through dependency injection when the ApplicationDbContext
instance is created. It's a way to configure and provide database-related settings to the context.
Constructor:
The constructor is like a special method that gets called when you create a new ApplicationDbContext.
It's a way to set things up for this database context.
DbContextOptions:
DbContextOptions is like a set of instructions or settings that tell your ApplicationDbContext 
how to connect to and interact with the database.
Dependency Injection:
When you create an instance of ApplicationDbContext, you can provide it with the necessary DbContextOptions using a technique called "dependency injection.
" Think of it as giving your ApplicationDbContext the tools it needs to work with the database.
Database-related Settings:
These settings are like rules or configurations that specify things like which database server to use, where the database is located, and how it should behave.
*/