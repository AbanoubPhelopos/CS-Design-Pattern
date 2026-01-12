using ShapesExample;

var shapes = new List<IShape>
{
    new Circle(2),
    new Square(5),
    new Square(6)
};

var areas = new AreaCalculator(shapes);
var output = new SumCalculatorOutputter(areas);

Console.WriteLine("--- SRP Shapes Example ---");
Console.WriteLine("JSON Output:");
Console.WriteLine(output.Json());
Console.WriteLine();
Console.WriteLine("HTML Output:");
Console.WriteLine(output.Html());
