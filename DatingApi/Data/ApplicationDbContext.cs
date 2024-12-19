using DatingApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApi.Data
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> AppUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = 1, Name = "John Doe", Email = "johndoe@example.com", Address = "123 Main Street" },
                new AppUser { Id = 2, Name = "Jane Smith", Email = "janesmith@example.com", Address = "456 Elm Street" },
                new AppUser { Id = 3, Name = "Alice Johnson", Email = "alicej@example.com", Address = "789 Oak Avenue" },
                new AppUser { Id = 4, Name = "Bob Brown", Email = "bobb@example.com", Address = "101 Pine Lane" }
            );
        }
    }
}
