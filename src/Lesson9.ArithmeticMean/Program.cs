namespace Lesson9.ArithmeticMean;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int, double> average = delegate(int a, int b, int c) { return (a + b + c) / 3.0; };

        Console.WriteLine("Введіть перше число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть третє число:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        double result = average(num1, num2, num3);
        Console.WriteLine($"Середнє арифметичне: {result}");
    }
}