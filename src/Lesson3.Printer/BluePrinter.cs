namespace Lesson3.Printer;

public class BluePrinter : Printer
{
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Print(value);
        Console.ResetColor();
    }
}