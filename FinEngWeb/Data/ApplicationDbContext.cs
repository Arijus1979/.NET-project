using FinEngWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FinEngWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Shoes", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "T-Shirts", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Pants", DisplayOrder = 3 },
                new Category { CategoryId = 4, Name = "Hats", DisplayOrder = 4 }
                );
        }
    }
}
