namespace Lesson4.Document;

class Footer : DocumentPart
{
    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}