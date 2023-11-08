namespace Library;

public class Content
{
    public string content;

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(content);
        
        // Resetting color of the text to make it default for other texts.
        Console.ResetColor();
    }
}