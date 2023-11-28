namespace Lesson4.AbstractHandler;

public class XMLHandler : AbstractHandler
{
    public override void Open() => Console.WriteLine("Opening XML document");
    public override void Create() => Console.WriteLine("Creating XML document");
    public override void Change() => Console.WriteLine("Changing XML document");
    public override void Save() => Console.WriteLine("Saving XML document");
}