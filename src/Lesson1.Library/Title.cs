namespace Lesson1.Library
{
    public class Title
    {
        public string title;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);

            // Resetting color of the text to make it default for other texts.
            Console.ResetColor();
        }
    }
}