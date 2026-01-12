namespace ShapesExample;

public class AreaCalculator
{
    private readonly List<IShape> _shapes;

    public AreaCalculator(List<IShape> shapes)
    {
        _shapes = shapes;
    }

    public double Sum()
    {
        return _shapes.Sum(shape => shape.Area());
    }
}
