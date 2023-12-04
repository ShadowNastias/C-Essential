namespace Lesson6.FindAndReplaceManager;

class Program
{
    static void Main(string[] args)
    {
        // Створення нової книги
        Book book = new Book("Текст книги, в якій ми хочемо знайти щось і додати нотатки.");

        // Пошук тексту
        book.FindNext("знайти");

        // Додавання нотаток
        book.BookNotes.AddNote("Це перша нотатка.");
        book.BookNotes.AddNote("Це друга нотатка.");

        // Отримання та вивід нотаток
        foreach (var note in book.BookNotes.GetNotes())
        {
            Console.WriteLine($"Нотатка: {note}");
        }
    }
}