namespace Lesson3.DocumentWorker;


public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ збережений у новому форматі");
    }
}