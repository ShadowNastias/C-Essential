namespace Lesson3.DocumentWorker;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ відкритий");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редагування документа у версії Про");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Збереження документа у версії Про");
    }
}