# SOLID Design Principles

## Overview

SOLID is an acronym for five fundamental principles of object-oriented programming and design that help create more maintainable, flexible, and scalable software. These principles were popularized by Robert C. Martin (Uncle Bob) and are derived from concepts in the Head First Design Patterns book.

---

## The Five Principles

### S - Single Responsibility Principle (SRP)

**Definition:** A class should have only one reason to change.

**From Head First Design Patterns:**
> "A class should have only one reason to change."

**Explanation:**
Every class should encapsulate only one responsibility or concern. If a class has multiple responsibilities, changes to one responsibility might break the other. This makes the system harder to change and test.

**Example:**
- A `Document` class should only handle document data, not printing
- A `User` class should only handle user data, not database operations
- A `Order` class should only handle order logic, not logging

**Benefits:**
- Easier to understand and maintain
- Better testability
- Reduced coupling
- Improved reusability

---

### O - Open/Closed Principle (OCP)

**Definition:** Classes should be open for extension but closed for modification.

**From Head First Design Patterns:**
> "Open for extension, closed for modification."

**Explanation:**
We should be able to add new functionality to a class without changing its existing code. This is achieved through abstraction, inheritance, and polymorphism.

**Example:**
- Use abstract base classes or interfaces
- Allow new behaviors through derived classes
- Use strategy patterns to swap algorithms

**Benefits:**
- Reduces risk of breaking existing functionality
- Makes the system more flexible
- Easier to add new features
- Promotes code reuse

---

### L - Liskov Substitution Principle (LSP)

**Definition:** Objects of a superclass should be replaceable with objects of its subclasses without affecting correctness.

**From Head First Design Patterns:**
> "Subclasses should be substitutable for their base classes."

**Explanation:**
If a class `B` is a subclass of class `A`, then we should be able to use `B` anywhere we use `A` without the program breaking. This means subclasses must honor the contracts of their parent classes.

**Example:**
- A `Square` should not be a subclass of `Rectangle` (since squares have different constraints)
- A `Bird` that cannot fly should not inherit from `FlyingBird`
- Derived classes must not strengthen preconditions or weaken postconditions

**Benefits:**
- Ensures inheritance is used correctly
- Prevents unexpected behavior
- Makes polymorphism work safely
- Reduces bugs

---

### I - Interface Segregation Principle (ISP)

**Definition:** Clients should not be forced to depend on interfaces they do not use.

**From Head First Design Patterns:**
> "Many client-specific interfaces are better than one general-purpose interface."

**Explanation:**
Instead of having one large interface with many methods, we should have multiple small, specific interfaces. Classes should only implement the methods they actually need.

**Example:**
- Instead of `IMachine` with `Print()`, `Scan()`, `Fax()`, create `IPrinter`, `IScanner`, `IFax`
- A `Smartphone` should not be forced to implement `ICamera` if it doesn't have a camera
- Separate interfaces for different client needs

**Benefits:**
- Reduces unused dependencies
- Makes interfaces more focused
- Improves maintainability
- Better testability

---

### D - Dependency Inversion Principle (DIP)

**Definition:** High-level modules should not depend on low-level modules. Both should depend on abstractions.

**From Head First Design Patterns:**
> "Depend upon abstractions. Do not depend upon concrete classes."

**Explanation:**
The high-level policy of the system should not depend on low-level details. Instead, both should depend on abstractions. This reduces coupling between modules.

**Example:**
- `OrderService` should depend on `IRepository`, not `SqlServerRepository`
- `PaymentProcessor` should depend on `IPaymentGateway`, not `PayPalGateway`
- Use dependency injection to provide dependencies

**Benefits:**
- Reduces coupling
- Makes unit testing easier (using mocks)
- Increases flexibility
- Enables swapping implementations

---

## How to Use This Folder

This folder contains two solutions to study the SOLID principles:

### 1. BrowserViolation (Bad Example)
This solution demonstrates a **real-world Google Chrome-inspired browser settings manager** that violates all five SOLID principles. The code uses console print statements extensively to simulate Google's complex debugging logging system.

**What you'll see:**
- Monolithic classes handling multiple responsibilities
- Switch statements that require modification for new features
- Inheritance used incorrectly causing LSP violations
- Fat interfaces forcing unused method implementations
- Direct dependencies on concrete classes

### 2. BrowserClean (Good Example - Models Only)
This solution provides the **model classes only** for you to refactor. The structure shows how the same functionality should be designed following SOLID principles.

**What you'll implement:**
- Separate classes for each responsibility
- Open/closed design using abstractions
- Proper inheritance hierarchies
- Segregated interfaces
- Dependency injection patterns

---

## Quick Reference

| Principle | Bad | Good |
|-----------|-----|------|
| **SRP** | God Class | Single Responsibility |
| **OCP** | Modify Existing Code | Extend via Polymorphism |
| **LSP** | Breaks Parent Contract | Honors Parent Contract |
| **ISP** | Fat Interface | Small, Focused Interfaces |
| **DIP** | Depends on Concrete | Depends on Abstraction |

---

## Key Takeaways

1. **SRP** keeps classes focused and small
2. **OCP** allows growth without modification
3. **LSP** ensures inheritance is used properly
4. **ISP** prevents forcing unused functionality
5. **DIP** reduces coupling through abstractions

> "Following SOLID principles won't guarantee your code is perfect, but it will make your code more maintainable, testable, and extensible." - Head First Design Patterns

---

## References

- Head First Design Patterns by Eric Freeman & Elisabeth Robson
- Clean Code by Robert C. Martin
- Agile Software Development by Robert C. Martin
