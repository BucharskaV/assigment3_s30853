using Assigment3Part2;
using InvalidOperationException = System.InvalidOperationException;

try
{
    Console.WriteLine("A = ");
    var a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("B = ");
    var b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the operation you would like to perform: ");
    var operation = Convert.ToChar(Console.ReadLine());

    var calculator = new Calculator(a, b, operation);
    var result = calculator.Calculate();

    Console.WriteLine($"The operation result is: {result}");
}
catch (FormatException)
{
    Console.WriteLine($"Enter valid numbers for A and B!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}