namespace Lesson4.Document;

public abstract class DocumentPart
{
    protected string content;

    public string Content
    {
        get
        {
            return content ?? "Вміст відсутній.";
        }
        set
        {
            content = value;
        }
    }

    public abstract void Show();
}