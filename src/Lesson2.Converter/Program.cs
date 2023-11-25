namespace Lesson2.Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.2, 39.5, 0.41);

            Console.WriteLine(converter.UAHtoUSD(100));
            Console.WriteLine(converter.USDtoUAH(100));
        }
    }
}