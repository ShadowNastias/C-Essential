namespace Lesson17.Calculator;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        dynamic x = 10;
        dynamic y = 5;

        Console.WriteLine($"Add: {calc.Add(x, y)}");
        Console.WriteLine($"Subtract: {calc.Subtract(x, y)}");
        Console.WriteLine($"Multiply: {calc.Multiply(x, y)}");
        Console.WriteLine($"Divide: {calc.Divide(x, y)}");
    }
}