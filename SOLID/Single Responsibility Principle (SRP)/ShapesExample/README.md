# Shapes Example (SRP)

This project demonstrates the Single Responsibility Principle (SRP) by refactoring a Shape Area Calculator.

## The Problem (Violating SRP)

Initially, we might have an `AreaCalculator` class that handles **both** the calculation logic for specific shapes AND the output formatting.

### Violating Code (C#)

```csharp
public class Square
{
    public double Length { get; set; }
    public Square(double length) { Length = length; }
}

public class Circle
{
    public double Radius { get; set; }
    public Circle(double radius) { Radius = radius; }
}

public class AreaCalculator
{
    protected List<object> _shapes;

    public AreaCalculator(List<object> shapes)
    {
        _shapes = shapes;
    }

    // Violation: The calculator knows the math for every shape.
    // If we add a Triangle, we must modify this class.
    public double Sum()
    {
        double area = 0;
        foreach (var shape in _shapes)
        {
            if (shape is Square s)
            {
                area += Math.Pow(s.Length, 2);
            }
            else if (shape is Circle c)
            {
                area += Math.PI * Math.Pow(c.Radius, 2);
            }
        }
        return area;
    }

    // Violation: The calculator handles output formatting.
    // If we want JSON, we must modify this class.
    public string Output()
    {
        return "Sum of the areas of provided shapes: " + Sum();
    }
}
```

## The Solution (Refactoring to SRP)

We split the responsibilities into three distinct parts:

1.  **Shapes (`Square`, `Circle`)**: Responsible for their own area calculation.
2.  **`AreaCalculator`**: Responsible for summing up areas (delegating the math to the shapes).
3.  **`SumCalculatorOutputter`**: Responsible for presenting the data (JSON, HTML, etc.).

### Refactored Code (C#)

**1. Shapes know their own Area**
```csharp
public interface IShape
{
    double Area();
}

public class Square : IShape
{
    public double Length { get; }
    public Square(double length) { Length = length; }
    public double Area() => Math.Pow(Length, 2);
}

public class Circle : IShape
{
    public double Radius { get; }
    public Circle(double radius) { Radius = radius; }
    public double Area() => Math.PI * Math.Pow(Radius, 2);
}
```

**2. AreaCalculator just sums**
```csharp
public class AreaCalculator
{
    private readonly List<IShape> _shapes;
    public AreaCalculator(List<IShape> shapes) { _shapes = shapes; }

    public double Sum()
    {
        return _shapes.Sum(shape => shape.Area());
    }
}
```

**3. Outputter handles presentation**
```csharp
public class SumCalculatorOutputter
{
    private readonly AreaCalculator _calculator;
    public SumCalculatorOutputter(AreaCalculator calculator) { _calculator = calculator; }

    public string Json()
    {
        var data = new { sum = _calculator.Sum() };
        return JsonSerializer.Serialize(data);
    }

    public string Html()
    {
        return $"Sum of the areas: {_calculator.Sum()}";
    }
}
```

This design adheres to SRP because `AreaCalculator` only changes if the *summing logic* changes, and `SumCalculatorOutputter` only changes if the *display format* changes.
