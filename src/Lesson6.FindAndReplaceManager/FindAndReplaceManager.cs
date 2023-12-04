namespace Lesson6.FindAndReplaceManager;

static class FindAndReplaceManager
{
    private static Book book;

    public static void InitializeBook(string content)
    {
        book = new Book(content);
    }

    public static void FindNext(string str)
    {
        book?.FindNext(str);
    }
}