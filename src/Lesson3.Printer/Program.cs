namespace Lesson3.Printer;

class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();
        printer.Print("This is the default printer");

        Printer redPrinter = new RedPrinter();
        redPrinter.Print("This is printed in red");

        Printer bluePrinter = new BluePrinter();
        bluePrinter.Print("This is printed in blue");

        Printer greenPrinter = new GreenPrinter();
        greenPrinter.Print("This is printed in green");
    }
}