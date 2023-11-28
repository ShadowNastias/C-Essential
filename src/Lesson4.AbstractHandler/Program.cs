namespace Lesson4.AbstractHandler;

class Program
{
    static void Main(string[] args)
    {
        AbstractHandler handler;


        string docType = "XML"; 

        switch (docType)
        {
            case "XML":
                handler = new XMLHandler();
                break;
            case "TXT":
                handler = new TXTHandler();
                break;
            case "DOC":
                handler = new DOCHandler();
                break;
            default:
                throw new InvalidOperationException("Unsupported document type");
        }

        handler.Open();
        handler.Create();
        handler.Change();
        handler.Save();
    }
}