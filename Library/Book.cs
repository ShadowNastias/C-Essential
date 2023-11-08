namespace Library;

public class Book
{
    private Title _title;
    private Author _author;
    private Content _content;

    // Method to set a title of the book.
    public void SetTitle(string title)
    {
        this._title = new Title { title = title };
    }
    
    // Method to set an author of the book.
    public void SetAuthor(string author)
    {
        this._author = new Author() { author = author };
    }
    
    // Method to set a content of the book.
    public void SetContent(string content)
    {
        this._content = new Content() { content = content };
    }
    
    // Method to show a book information all together.
    public void ShowBook()
    {
        _title.Show();
        _author.Show();
        _content.Show();
    }
}
