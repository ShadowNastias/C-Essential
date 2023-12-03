namespace Lesson5.Article;

public class Article
{
    private string productName;
    private string storeName;
    private decimal price;

    public Article(string productName, string storeName, decimal price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.price = price;
    }

    public string ProductName => productName;
    public string StoreName => storeName;
    public decimal Price => price;

    public override string ToString()
    {
        return $"Product: {productName}, Store: {storeName}, Price: {price} UAH";
    }
}