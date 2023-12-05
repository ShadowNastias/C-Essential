namespace Lesson15.Price;

class Program
{
    static void Main(string[] args)
    {
        Price[] prices = new Price[2];

        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine($"Enter details for product {i+1}:");
            
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter shop name: ");
            string shopName = Console.ReadLine();

            Console.Write("Enter cost (in UAH): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal cost))
            {
                Console.WriteLine("You entered an invalid cost. Please enter a numeric value.");
                i--; // decrement the counter to retry the current iteration
                continue;
            }

            prices[i] = new Price(productName, shopName, cost);
        }

        // Sorting by shop name
        Array.Sort(prices, (p1, p2) => p1.ShopName.CompareTo(p2.ShopName));

        Console.Write("Enter the name of the shop to display its products: ");
        string inputShopName = Console.ReadLine();
        bool shopFound = false;

        foreach (var price in prices)
        {
            if (price.ShopName.Equals(inputShopName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Product: {price.ProductName}, Cost: {price.Cost} UAH");
                shopFound = true;
            }
        }

        if (!shopFound)
        {
            Console.WriteLine($"No products found for shop: {inputShopName}");
        }
    }
}