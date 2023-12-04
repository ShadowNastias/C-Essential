namespace Lesson8.Print;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string userInput = Console.ReadLine();

        Console.WriteLine("Виберіть колір (0 - Чорний, 1 - Синій, 2 - Зелений, 3 - Червоний):");
        if (int.TryParse(Console.ReadLine(), out int colorChoice) && colorChoice >= 0 && colorChoice <= 3)
        {
            Print(userInput, colorChoice);
        }
        else
        {
            Console.WriteLine("Неправильний вибір кольору.");
        }
    }

    static void Print(string stroka, int color)
    {
        ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Red };
        Console.ForegroundColor = colors[color];
        Console.WriteLine(stroka);
        Console.ResetColor();
    }
}