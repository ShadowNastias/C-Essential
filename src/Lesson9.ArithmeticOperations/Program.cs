namespace Lesson9.ArithmeticOperations;

class Program
{
    static void Main(string[] args)
    {
        Func<double, double, double> Add = (x, y) => x + y;
        Func<double, double, double> Sub = (x, y) => x - y;
        Func<double, double, double> Mul = (x, y) => x * y;
        Func<double, double, double> Div = (x, y) => y != 0 ? x / y :
            throw new DivideByZeroException("Division by zero is not allowed.");

        Console.WriteLine("Виберіть операцію: Add, Sub, Mul, Div");
        string operation = Console.ReadLine().ToLower();

        Console.WriteLine("Введіть перше число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double num2 = double.Parse(Console.ReadLine());

        double result = operation switch
        {
            "add" => Add(num1, num2),
            "sub" => Sub(num1, num2),
            "mul" => Mul(num1, num2),
            "div" => Div(num1, num2),
            _ => throw new InvalidOperationException("Неправильна операція")
        };

        Console.WriteLine($"Результат: {result}");
    }
}