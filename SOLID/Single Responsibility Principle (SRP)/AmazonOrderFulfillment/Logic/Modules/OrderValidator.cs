namespace AmazonOrderFulfillment.Logic.Modules;
using AmazonOrderFulfillment.Logic.Models;

public class OrderValidator
{
    public bool Validate(Order order)
    {
        if (order.Items == null || !order.Items.Any())
        {
            Console.WriteLine("[Validation] Failed: Order has no items.");
            return false;
        }

        // Simulating Inventory Check
        Console.WriteLine($"[Validation] Order {order.OrderId} validated. Inventory checked.");
        return true;
    }
}