using AmazonOrderFulfillment.Logic.Models;
using AmazonOrderFulfillment.Logic.Modules;

// Input Data
var order = new Order
{
    OrderId = "ORD-2026-001",
    Customer = new Customer { Name = "Abanoub Saweris", Email = "abanoub@example.com", State = "EG" },
    Items = new List<Item>
    {
        new Item { Name = "Laptop", Price = 1200.00m },
        new Item { Name = "Mouse", Price = 25.00m }
    }
};

// Execute
var orderManager = new OrderManager();
orderManager.ProcessOrder(order);