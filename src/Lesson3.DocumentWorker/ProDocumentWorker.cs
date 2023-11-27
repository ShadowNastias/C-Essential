namespace Lesson3.DocumentWorker;

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ відредаговано");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
    }
}