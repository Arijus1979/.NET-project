using FinEng.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinEng.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<OrderHeader> OrderHeaders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Shoes", DisplayOrder = 1 },
            new Category { CategoryId = 2, Name = "T-Shirts", DisplayOrder = 2 },
            new Category { CategoryId = 3, Name = "Pants", DisplayOrder = 3 },
            new Category { CategoryId = 4, Name = "Hats", DisplayOrder = 4 }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Title = "Nike Air Max 90",
                Description = "Nike Air Max 90 Shoes",
                Price = "100",
                Price2 = "90",
                CategoryId = 1,
                ImageUrl = ""
            },
            new Product
            {
                ProductId = 2,
                Title = "Nike Air Max 95",
                Description = "Nike Air Max 95 Shoes",
                Price = "120",
                Price2 = "110",
                CategoryId = 1,
                ImageUrl = ""
            },
            new Product
            {
                ProductId = 3,
                Title = "Nike Air Max 97",
                Description = "Nike Air Max 97 Shoes",
                Price = "140",
                Price2 = "130",
                CategoryId = 2,
                ImageUrl = ""
            },
            new Product
            {
                ProductId = 4,
                Title = "Nike Air Max 98",
                Description = "Nike Air Max 98 Shoes",
                Price = "160",
                Price2 = "150",
                CategoryId = 3,
                ImageUrl = ""
            },
            new Product
            {
                ProductId = 5,
                Title = "Nike Air Max 270",
                Description = "Nike Air Max 270 Shoes",
                Price = "180",
                Price2 = "170",
                CategoryId = 4,
                ImageUrl = ""
            }
        );
    }
}