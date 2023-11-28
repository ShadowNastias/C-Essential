namespace Lesson4.Document;

class Body : DocumentPart
{
    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}