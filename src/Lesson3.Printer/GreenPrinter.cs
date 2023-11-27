namespace Lesson3.Printer;

public class GreenPrinter : Printer
{
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Print(value);
        Console.ResetColor();
    }
}