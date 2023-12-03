namespace Lesson5.Article;

class Program
{
    static void Main(string[] args)
    {
        Store store = new Store(5);
        store[0] = new Article("Laptop", "TechStore", 25000m);
        store[1] = new Article("Smartphone", "TechWorld", 15000m);
        store[2] = new Article("Headphones", "SoundShop", 3000m);
        store[3] = new Article("Monitor", "ComputerWorld", 8000m);
        store[4] = new Article("Keyboard", "TechStore", 2000m);
        
        Console.WriteLine("Enter the index of the article to display:");
        int index = int.Parse(Console.ReadLine());
        store.DisplayArticle(index);
        
        Console.WriteLine("Enter the name of the article to display:");
        string productName = Console.ReadLine();
        store.DisplayArticle(productName);
    }
}