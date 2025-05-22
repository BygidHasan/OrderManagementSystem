using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<Order> Orders { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Order>().HasData(
      new Order
      {
        Id = 1,
        CustomerName = "Alice Smith",
        ProductName = "Laptop",
        Quantity = 1,
        OrderDate = new DateTime(2025, 5, 20)
      },
      new Order
      {
        Id = 2,
        CustomerName = "Bob Smith",
        ProductName = "Smartphone",
        Quantity = 2,
        OrderDate = new DateTime(2025, 5, 21)
      },
      new Order
      {
        Id = 3,
        CustomerName = "John Doe",
        ProductName = "Tablet",
        Quantity = 3,
        OrderDate = new DateTime(2025, 5, 22)
      }
    );
  }

  

}