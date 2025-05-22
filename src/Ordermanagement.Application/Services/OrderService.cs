using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Application.Services
{
    public class OrderService(AppDbContext context) : IOrderService
    {
      private readonly AppDbContext _context = context;

      public async Task<List<Order>> GetAllOrdersAsync()
      {
          return await _context.Orders.ToListAsync();
      }
      
      public async Task<Order?> GetOrderByIdAsync(int id)
      {
        return await _context.Orders.FindAsync(id);
      }
      public async Task<Order> CreateOrderAsync(Order order)
      {
          await _context.Orders.AddAsync(order);
          await _context.SaveChangesAsync();
          return order;
      }

    public async Task<Order?> UpdateOrderAsync(Order order)
    {
      var existingOrder = await _context.Orders.FindAsync(order.Id);
      if (existingOrder == null) return null;

      existingOrder.CustomerName = order.CustomerName;
      existingOrder.ProductName = order.ProductName;
      existingOrder.Quantity = order.Quantity;
      existingOrder.OrderDate = order.OrderDate;

      await _context.SaveChangesAsync();
      return existingOrder;
    }

      public async Task<bool> DeleteOrderAsync(int id)
    {
      var order = await _context.Orders.FindAsync(id);
      if (order != null)
      {
        _context.Orders.Remove(order);
        var result = await _context.SaveChangesAsync();
        return result > 0;
      }
      return false;
    }
    }
}