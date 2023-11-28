namespace Lesson4.AbstractHandler;

public class DOCHandler : AbstractHandler
{
    public override void Open() => Console.WriteLine("Opening DOC document");
    public override void Create() => Console.WriteLine("Creating DOC document");
    public override void Change() => Console.WriteLine("Changing DOC document");
    public override void Save() => Console.WriteLine("Saving DOC document");
}