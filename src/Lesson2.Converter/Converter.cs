namespace Lesson2.Converter
{
    public class Converter
    {
        private double usdRate;
        private double eurRate;
        private double rubRate;

        public Converter(double usd, double eur, double rub)
        {
            this.usdRate = usd;
            this.eurRate = eur;
            this.rubRate = rub;
        }

        public double UAHtoUSD(double uah)
        {
            return uah / usdRate;
        }

        public double UAHtoEUR(double uah)
        {
            return uah / eurRate;
        }

        public double UAHtoRUB(double uah)
        {
            return uah / rubRate;
        }

        public double USDtoUAH(double usd)
        {
            return usd * usdRate;
        }

        public double EURtoUAH(double eur)
        {
            return eur * eurRate;
        }

        public double RUBtoUAH(double rub)
        {
            return rub * rubRate;
        }
    }
}