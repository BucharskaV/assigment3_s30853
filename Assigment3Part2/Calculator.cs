namespace Assigment3Part2;

public class Calculator
{
    public double A { get; set; }
    public double B { get; set; }
    public char Operation { get; set; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        var result = Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => B != 0 ? A / B : throw new ArgumentException("The divisor can not be zero!"),
            _ => throw new InvalidOperationException(Operation)
        };
        return result;
    }
}