namespace OrderManagement.Domain.Entities
{
  public class Order
  {
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; }
  }
}