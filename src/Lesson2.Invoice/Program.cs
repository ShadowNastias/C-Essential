namespace Lesson2.Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(
                123, 
                "CustomerName", 
                "ProviderName", 
                "ArticleName", 
                5);

            double priceWithoutVAT = 100.0; 
            double vatRate = 0.2; 

            double totalPriceWithVAT = invoice.CalculateTotalPriceWithVAT(priceWithoutVAT, vatRate);
            double totalPriceWithoutVAT = invoice.CalculateTotalPriceWithoutVAT(priceWithoutVAT);
            
            Console.WriteLine($"Total Price Without VAT: {totalPriceWithoutVAT}");
            Console.WriteLine($"Total Price With VAT: {totalPriceWithVAT}");
        }
    }
}