namespace AmazonOrderFulfillment.Logic.Modules;
using AmazonOrderFulfillment.Logic.Models;

public class InvoiceGenerator
{
    public void GenerateInvoice(Order order, decimal subtotal, decimal tax, decimal total)
    {
        Console.WriteLine($"[Invoice] Generating Invoice for {order.Customer.Name}...");
        Console.WriteLine($"   -- INVOICE {order.OrderId} --");
        Console.WriteLine($"   Total: ${subtotal}");
        Console.WriteLine($"   Tax: ${tax}");
        Console.WriteLine($"   Grand Total: ${total}");
        Console.WriteLine("   --------------------------");
    }
}