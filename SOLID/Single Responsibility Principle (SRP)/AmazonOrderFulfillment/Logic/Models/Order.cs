namespace AmazonOrderFulfillment.Logic.Models;

public class Order
{
    public string OrderId { get; set; }
    public List<Item> Items { get; set; }
    public Customer Customer { get; set; }
}