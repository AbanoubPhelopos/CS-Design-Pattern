namespace AmazonOrderFulfillment.Logic.Modules;

public class EmailNotifier
{
    public void SendConfirmation(string email)
    {
        Console.WriteLine($"[Email] Email sent to {email}: \"Your order is confirmed!\"");
    }
}