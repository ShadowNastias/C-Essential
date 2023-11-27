namespace Lesson3.Printer;

public class RedPrinter : Printer
{
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Print(value);
        Console.ResetColor();
    }
}