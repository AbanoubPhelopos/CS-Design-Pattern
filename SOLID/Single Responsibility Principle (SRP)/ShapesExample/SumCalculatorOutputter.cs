using System.Text.Json;

namespace ShapesExample;

public class SumCalculatorOutputter
{
    private readonly AreaCalculator _calculator;

    public SumCalculatorOutputter(AreaCalculator calculator)
    {
        _calculator = calculator;
    }

    public string Json()
    {
        var data = new { sum = _calculator.Sum() };
        return JsonSerializer.Serialize(data);
    }

    public string Html()
    {
        return $@"
        Sum of the areas of provided shapes: {_calculator.Sum()}
        ";
    }
}
