namespace Lesson17.Dictionary;

class Program
{
    static void Main()
    {
        var dictionary = new List<dynamic>
        {
            new { English = "apple", Russian = "яблоко" },
            new { English = "book", Russian = "книга" },
            new { English = "cat", Russian = "кот" },
            new { English = "dog", Russian = "собака" },
            new { English = "elephant", Russian = "слон" },
            new { English = "flower", Russian = "цветок" },
            new { English = "grape", Russian = "виноград" },
            new { English = "house", Russian = "дом" },
            new { English = "island", Russian = "остров" },
            new { English = "juice", Russian = "сок" }
        };

        Console.WriteLine("Англо-Російський словник:");
        foreach (var word in dictionary)
        {
            Console.WriteLine($"{word.English} - {word.Russian}");
        }
    }
}