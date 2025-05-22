using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;

namespace OrderManagement.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class OrdersController(IOrderService orderService) : ControllerBase
  {
    private readonly IOrderService _orderService = orderService;

    [HttpGet]
    public async Task<ActionResult<List<Order>>> GetAll()
    {
      var orders = await _orderService.GetAllOrdersAsync();
      return Ok(orders);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> GetById(int id)
    {
      var order = await _orderService.GetOrderByIdAsync(id);
      if (order == null)
      {
        return NotFound();
      }
      return Ok(order);
    }

    [HttpPost]
    public async Task<ActionResult<Order>> Create(Order order)
    {
      var created = await _orderService.CreateOrderAsync(order);
      return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Order>> Update(int id, Order order)
    {
      if (id != order.Id)
      {
        return BadRequest("Id mismatch");
      }

      var updated = await _orderService.UpdateOrderAsync(order);
      if (updated == null)
      {
        return NotFound();
      }
      return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var deleted = await _orderService.DeleteOrderAsync(id);
      if (!deleted)
      {
        return NotFound();
      }
      return NoContent();
    }
  }
}