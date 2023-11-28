namespace Lesson4.Document;

class Title : DocumentPart
{
    public override void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}