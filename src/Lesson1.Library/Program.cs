namespace Lesson1.Library;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new instance of the Book class.
        Book book_1 = new Book();
        
        // Defining author, title and content for the first book.
        book_1.SetAuthor("Jane Austen");
        book_1.SetTitle("Pride and Prejudice");
        book_1.SetContent("Pride and Prejudice is an 1813 novel of manners by English author Jane Austen. " +
                        "The novel follows the character development of Elizabeth Bennet, " +
                        "the protagonist of the book, who learns about the repercussions of hasty judgments " +
                        "and comes to appreciate the difference between superficial goodness and actual goodness.");
        
        book_1.ShowBook();
    }
}