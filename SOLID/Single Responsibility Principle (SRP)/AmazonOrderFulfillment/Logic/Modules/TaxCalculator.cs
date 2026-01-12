namespace AmazonOrderFulfillment.Logic.Modules;

public class TaxCalculator
{
    public decimal CalculateTax(decimal subtotal, string state)
    {
        decimal rate = 0.05m;
        if (state == "CA") rate = 0.0725m;
        if (state == "NY") rate = 0.088m;
        if (state == "EG") rate = 0.14m;

        decimal taxAmount = Math.Round(subtotal * rate, 2);
        Console.WriteLine($"[Tax] State is {state}. Tax rate: {rate * 100}%. Tax Amount: ${taxAmount}.");
        return taxAmount;
    }
}