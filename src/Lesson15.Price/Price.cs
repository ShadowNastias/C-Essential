namespace Lesson15.Price;

struct Price
{
    public string ProductName;
    public string ShopName;
    public decimal Cost;

    public Price(string productName, string shopName, decimal cost)
    {
        ProductName = productName;
        ShopName = shopName;
        Cost = cost;
    }
}