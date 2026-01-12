# Amazon Order Fulfillment Example (SRP)

This project demonstrates the Single Responsibility Principle (SRP) in a real-world e-commerce scenario.

## The Context

Processing an order involves multiple distinct operations:
*   Inventory checking
*   Tax calculation (which varies by state)
*   Payment processing
*   Invoice generation
*   Email notifications

## The Problem (Violating SRP)

A monolithic `OrderService` class that does everything.

### Violating Code (Concept)

```csharp
public class OrderService
{
    public void Process(Order order)
    {
        // 1. Validation Logic
        if(order.Items.Count == 0) throw new Exception("Empty order");
        
        // 2. Tax Logic
        decimal tax = 0;
        if(order.State == "CA") tax = order.Total * 0.0725m;
        
        // 3. Payment Logic
        // Call payment gateway API...
        
        // 4. Email Logic
        // Construct SMTP client...
        // Send email...
    }
}
```

**Why this fails**: If the Finance team changes the tax rate for California, you have to edit the same file that handles sending emails. This increases the risk of bugs and makes the code hard to maintain.

## The Solution (Refactoring to SRP)

We split the logic into dedicated classes, orchestrated by an `OrderManager`.

### 1. Validator
Responsible ONLY for validating the order.
```csharp
public class OrderValidator
{
    public bool Validate(Order order) { ... }
}
```

### 2. Tax Calculator
Responsible ONLY for tax rules.
```csharp
public class TaxCalculator
{
    public decimal CalculateTax(decimal subtotal, string state) { ... }
}
```

### 3. Payment Processor
Responsible ONLY for talking to the payment gateway.
```csharp
public class PaymentProcessor
{
    public bool ProcessPayment(decimal amount) { ... }
}
```

### 4. Invoice Generator & Email Notifier
Separate classes for generating documents and sending notifications.

### 5. Order Manager (Orchestrator)
The `OrderManager` ties it all together. It delegates work to the specialized classes. It doesn't know *how* to calculate tax, it just asks the `TaxCalculator` to do it.

```csharp
public class OrderManager
{
    public void ProcessOrder(Order order)
    {
        if(!_validator.Validate(order)) return;
        
        var tax = _taxCalculator.CalculateTax(order.SubTotal, order.State);
        _paymentProcessor.ProcessPayment(order.SubTotal + tax);
        _invoiceGenerator.Generate(order);
        _emailNotifier.Send(order.Email);
    }
}
```
