namespace Lesson4.Document;

class Program
{
    static void Main()
    { 
        Document document = new Document("Контракт");
        document.Body = "Тіло контракту...";
        document.Footer = "Директор: Іванов І.І.";

        document.Show();

        // Delay.
        Console.ReadKey();
    }
}