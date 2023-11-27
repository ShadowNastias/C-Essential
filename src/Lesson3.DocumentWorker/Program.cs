namespace Lesson3.DocumentWorker;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть ключ доступу (залиште порожнім для базової версії):");
        string key = Console.ReadLine();
        DocumentWorker worker;

        switch (key)
        {
            case "pro":
                worker = new ProDocumentWorker();
                break;
            case "exp":
                worker = new ExpertDocumentWorker();
                break;
            default:
                worker = new DocumentWorker();
                break;
        }

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}