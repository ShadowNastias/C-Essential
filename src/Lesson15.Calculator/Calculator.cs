namespace Lesson15.Calculator;

class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Sub(double a, double b)
    {
        return a - b;
    }

    public static double Mul(double a, double b)
    {
        return a * b;
    }

    public static double Div(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Division by zero is not allowed.");
        return a / b;
    }
}