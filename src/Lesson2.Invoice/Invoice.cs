namespace Lesson2.Invoice
{
    public class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        private string article;
        private int quantity; 
        
        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public double CalculateTotalPriceWithVAT(double priceWithoutVAT, double vatRate)
        {
            return priceWithoutVAT * (1 + vatRate) * quantity;
        }
        
        public double CalculateTotalPriceWithoutVAT(double priceWithoutVAT)
        {
            return priceWithoutVAT * quantity;
        }
    }
}

