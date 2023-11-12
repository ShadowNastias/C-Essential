namespace Lesson1.Library;

public class Author
{
    public string author;

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(author);
        
        // Resetting color of the text to make it default for other texts.
        Console.ResetColor();
    }
}