namespace Lesson15.Calculator;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        try
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (Add, Sub, Mul, Div): ");
            string operation = Console.ReadLine().Trim();

            double result = 0;

            switch (operation.ToLower())
            {
                case "add":
                    result = Calculator.Add(num1, num2);
                    break;
                case "sub":
                    result = Calculator.Sub(num1, num2);
                    break;
                case "mul":
                    result = Calculator.Mul(num1, num2);
                    break;
                case "div":
                    result = Calculator.Div(num1, num2);
                    break;
                default:
                    throw new Exception("Invalid operation.");
            }

            Console.WriteLine($"The result is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: You have entered an invalid number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}