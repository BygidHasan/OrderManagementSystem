using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Data
{
    public static class AppDbContextSeed
    {
      public static async Task Seed(AppDbContext context)
      {
        if (context.Orders.Any()) return;
      var orders = new List<Order>
        {
          new() { Id = 1, CustomerName = "Alice Smith", ProductName = "Laptop", Quantity = 1, OrderDate = new DateTime(2025, 5, 20) },
          new() { Id = 2, CustomerName = "Bob Smith", ProductName = "Smartphone", Quantity = 2, OrderDate = new DateTime(2025, 5, 21) },
          new() { Id = 3, CustomerName = "John Doe", ProductName = "Tablet", Quantity = 3, OrderDate = new DateTime(2025, 5, 22) },
        };
        await context.Orders.AddRangeAsync(orders);
        await context.SaveChangesAsync();
      }
    }
}