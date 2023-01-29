using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace DAL;

public class StoreContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }

    public DbSet<Product> Reviews { get; set; }

    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderProduct>()
            .HasKey(op => new { op.OrderId, op.ProductId });
            

        modelBuilder.Entity<Customer>().HasData(
            new { Id = Guid.NewGuid(), Email = "customer1@email.com", Password = "secret" },
            new { Id = Guid.NewGuid(), Email = "customer2@email.com", Password = "secret" },
            new { Id = Guid.NewGuid(), Email = "customer3@email.com", Password = "secret" },
            new { Id = Guid.NewGuid(), Email = "customer4@email.com", Password = "secret" }
        );

        modelBuilder.Entity<Product>().HasData(
            new { Id = Guid.NewGuid(), Name = "Product A", Price = 12.505, Description= "Watch", ImageUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1099&q=80" },
            new { Id = Guid.NewGuid(), Name = "Product B", Price = 52.50, Description = "Headphones", ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" },
            new { Id = Guid.NewGuid(), Name = "Product C", Price = 102.50, Description = "Sunglasses", ImageUrl = "https://images.unsplash.com/photo-1572635196237-14b3f281503f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80" },
            new { Id = Guid.NewGuid(), Name = "Product D", Price = 202.50, Description = "Shoes", ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80" }
        );
    }
}
