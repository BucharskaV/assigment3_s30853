using Assigment3Part2;
using InvalidOperationException = Assigment3Part2.InvalidOperationException;

namespace TestsAssigment3Part2;

public class TestsCalculator
{
    [TestCase(-15, 2, '+', -13)]
    [TestCase(15, 2, '+', 17)]
    [TestCase(10, -2, '+', 8)]
    [TestCase(5, 0, '+', 5)]
    public void Calculate_Addition_ReturnsCorrectResult(double a, double b, char operation, double expectedResult)
    {
        var calc = new Calculator(a, b, operation);
        Assert.That(calc.Calculate(), Is.EqualTo(expectedResult));
    }
    
    [TestCase(15, 2, '-', 13)]
    [TestCase(-10, -2, '-', -8)]
    [TestCase(0, 2, '-', -2)]
    public void Calculate_Subtraction_ReturnsCorrectResult(double a, double b, char operation, double expectedResult)
    {
        var calc = new Calculator(a, b, operation);
        Assert.That(calc.Calculate(), Is.EqualTo(expectedResult));
    }
    
    [TestCase(15, 2, '*', 30)]
    [TestCase(15, -2, '*', -30)]
    [TestCase(-10, -2, '*', 20)]
    [TestCase(0, 2, '*', 0)]
    public void Calculate_Multiplication_ReturnsCorrectResult(double a, double b, char operation, double expectedResult)
    {
        var calc = new Calculator(a, b, operation);
        Assert.That(calc.Calculate(), Is.EqualTo(expectedResult));
    }
    
    [TestCase(15, 2, '/', 7.5)]
    [TestCase(15, -2, '/', -7.5)]
    [TestCase(-10, -2, '/', 5)]
    [TestCase(0, 2, '/', 0)]
    public void Calculate_Division_ReturnsCorrectResult(double a, double b, char operation, double expectedResult)
    {
        var calc = new Calculator(a, b, operation);
        Assert.That(calc.Calculate(), Is.EqualTo(expectedResult));
    }

    [Test]
    public void Calculate_DivisionByZero_ThrowsException()
    {
        var calc = new Calculator(3, 0, '/');
        Assert.Throws<ArgumentException>(() => calc.Calculate());
    }
    
    [Test]
    public void Calculate_InvalidOperation_ThrowsException()
    {
        var calc = new Calculator(3, 30, 'a');
        Assert.Throws<InvalidOperationException>(() => calc.Calculate());
    }
    
    [TestCase(15.5, Math.PI, '+', 18.641)]
    [TestCase(15.5, Math.PI, '-', 12.358)]
    [TestCase(15.5, Math.PI, '*', 48.694)]
    [TestCase(15.5, Math.PI, '/', 4.933)]
    public void Calculate_FloatingPointNumbers_ReturnsCorrectResult(double a, double b, char operation, double expectedResult)
    {
        var calc = new Calculator(a, b, operation);
        Assert.That(calc.Calculate(), Is.EqualTo(expectedResult).Within(0.001));
    }
    
    [Test]
    public void Calculate_LargeNumbers_ReturnsCorrectResult()
    {
        var calc = new Calculator(1e10, 1e10, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(2e10));
    }
}