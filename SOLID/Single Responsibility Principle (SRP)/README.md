# Single Responsibility Principle (SRP)

The Single Responsibility Principle (SRP) states that **"A class should have only one reason to change"**, meaning that a class should have only one job or purpose within the software system.

## Practical Examples

This repository contains three examples applying SRP in C#:

### 1. [Shapes Example](./ShapesExample)
A classic example involving geometric shapes.
*   **Problem**: An `AreaCalculator` that calculates areas for every shape AND formats the output.
*   **Solution**: Segregate responsibilities into `IShape` (calculation), `AreaCalculator` (summing), and `SumCalculatorOutputter` (formatting).

### 2. [Amazon Order Fulfillment](./AmazonOrderFulfillment)
A real-world e-commerce scenario.
*   **Problem**: A monolithic `OrderService` handling validation, tax, payments, and emails.
*   **Solution**: Specialized modules (`TaxCalculator`, `PaymentProcessor`, etc.) orchestrated by an `OrderManager`.

### 3. [Bakery Example](./BakeryExample)
A conceptual analogy.
*   **Problem**: A Baker doing baking, cleaning, and inventory.
*   **Solution**: Separate roles for `BreadBaker`, `InventoryManager`, `BakeryCleaner`, etc.

## References & Further Reading

*   [DigitalOcean: S.O.L.I.D. The First Five Principles of Object-Oriented Design](https://www.digitalocean.com/community/conceptual-articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design#single-responsibility-principle)
*   [GeeksForGeeks: SOLID Design Principles](https://www.geeksforgeeks.org/system-design/solid-principle-in-programming-understand-with-real-life-examples/)

## How to Run
Navigate to any of the solution folders and run:
```bash
dotnet run
```
