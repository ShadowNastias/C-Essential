namespace Lesson4.AbstractHandler;

public class TXTHandler : AbstractHandler
{
    public override void Open() => Console.WriteLine("Opening TXT document");
    public override void Create() => Console.WriteLine("Creating TXT document");
    public override void Change() => Console.WriteLine("Changing TXT document");
    public override void Save() => Console.WriteLine("Saving TXT document");
}