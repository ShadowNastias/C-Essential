namespace Lesson6.Calculator;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 10;
        double num2 = 5;

        Console.WriteLine($"Addition: {num1} + {num2} = {Calculator.Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {Calculator.Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {Calculator.Multiply(num1, num2)}");
        Console.WriteLine($"Division: {num1} / {num2} = {Calculator.Divide(num1, num2)}");
    }
}