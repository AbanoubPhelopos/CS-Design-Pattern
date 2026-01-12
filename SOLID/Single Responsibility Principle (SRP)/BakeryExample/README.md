# Bakery Example (SRP)

This simple example illustrates SRP using a Bakery analogy.

## The Concept

Imagine a baker who is responsible for:
1.  Baking Bread
2.  Managing Inventory
3.  Ordering Supplies
4.  Serving Customers
5.  Cleaning

If one person (or one Class) does all this, their focus is divided. If the method of "Ordering Supplies" changes (e.g., new software), we shouldn't have to touch the "Baking Bread" code.

## The Problem (Violating SRP)

```csharp
// One class doing everything
class Baker
{
    public void BakeBread() { ... }
    public void OrderSupplies() { ... } // Reason to change: Supplier changes
    public void CleanBakery() { ... }   // Reason to change: Cleaning protocols change
}
```

## The Solution (Refactoring to SRP)

We create specialized classes for each responsibility.

### Refactored Code (C#)

```csharp
// Responsible solely for baking bread
public class BreadBaker 
{
    public void BakeBread() 
    {
        Console.WriteLine("Baking high-quality bread...");
    }
}

// Responsible solely for inventory
public class InventoryManager 
{
    public void ManageInventory() 
    {
        Console.WriteLine("Managing inventory...");
    }
}

// Responsible solely for supplies
public class SupplyOrder 
{
    public void OrderSupplies() 
    {
        Console.WriteLine("Ordering supplies...");
    }
}

// Responsible solely for customers
public class CustomerService 
{
    public void ServeCustomer() 
    {
        Console.WriteLine("Serving customers...");
    }
}

// Responsible solely for cleaning
public class BakeryCleaner 
{
    public void CleanBakery() 
    {
        Console.WriteLine("Cleaning the bakery...");
    }
}
```

### Usage

```csharp
BreadBaker baker = new BreadBaker();
InventoryManager inventory = new InventoryManager();

baker.BakeBread();
inventory.ManageInventory();
```

Each class now has **one reason to change**.
