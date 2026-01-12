namespace AmazonOrderFulfillment.Logic.Modules;

public class PaymentProcessor
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Payment] Processing payment of ${amount}... Payment Successful.");
        return true;
    }
}