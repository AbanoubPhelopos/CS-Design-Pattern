namespace ShapesExample;

public class Square : IShape
{
    public double Length { get; }

    public Square(double length)
    {
        Length = length;
    }

    public double Area()
    {
        return Math.Pow(Length, 2);
    }
}
