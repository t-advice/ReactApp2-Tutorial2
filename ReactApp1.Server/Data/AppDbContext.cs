using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Models;


namespace ReactApp1.Server.Data
{
    // Inherit from DbContext to create a database context for EF Core
    public class AppDbContext : DbContext
    {
        // This DbSet represents the collection of TodoItem entities in the database
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {

        }

        // This line tells EF Core: "I want a table in the DB called 'TodoItems'"
        public DbSet<TodoItem> TodoItems { get; set; } 
        
    }
}
