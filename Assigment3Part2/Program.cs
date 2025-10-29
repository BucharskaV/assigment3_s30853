using Assigment3Part2;
using InvalidOperationException = System.InvalidOperationException;

try
{
    /*Calculator calc = new Calculator(10, 5, '-');
    Console.WriteLine($"10 - 5 = {calc.Calculate()}");
    
    Calculator calc1 = new Calculator(10, 5, '+');
    Console.WriteLine($"10 + 5 = {calc1.Calculate()}");
    
    Calculator calc2 = new Calculator(10, 5, '*');
    Console.WriteLine($"10 * 5 = {calc2.Calculate()}");
    
    Calculator calc3 = new Calculator(10, 5, '/');
    Console.WriteLine($"15 / 3 = {calc3.Calculate()}");
    
    Calculator calc4 = new Calculator(10, 0, '/');
    Console.WriteLine(calc4.Calculate());
    
    Calculator calc5 = new Calculator(10, 5, 'a');
    Console.WriteLine(calc5.Calculate());*/
    
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