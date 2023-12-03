namespace Lesson5.Article;

public class Store
{
    private Article[] articles;

    public Store(int size)
    {
        articles = new Article[size];
    }

    public Article this[int index]
    {
        get { return articles[index]; }
        set { articles[index] = value; }
    }

    public void DisplayArticle(int index)
    {
        if (index >= 0 && index < articles.Length)
        {
            Console.WriteLine(articles[index]);
        }
        else
        {
            Console.WriteLine("Article with the given index does not exist.");
        }
    }

    public void DisplayArticle(string productName)
    {
        foreach (var article in articles)
        {
            if (article != null && article.ProductName.ToLower() == productName.ToLower())
            {
                Console.WriteLine(article);
                return;
            }
        }
        Console.WriteLine("No article with the given name was found.");
    }
}