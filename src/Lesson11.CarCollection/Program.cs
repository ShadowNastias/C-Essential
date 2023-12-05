namespace Lesson11.CarCollection;

class Program
{
    static void Main(string[] args)
    {
        CarCollection cars = new CarCollection();
        cars.AddCar("Tesla Model S", 2020);
        cars.AddCar("Ford Mustang", 1965);

        Console.WriteLine("Автопарк:");
        for (int i = 0; i < cars.Count; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Console.WriteLine($"\nЗагальна кількість машин: {cars.Count}");
        
        cars.Clear();
        Console.WriteLine($"\nПісля очищення, загальна кількість машин: {cars.Count}");
    }
}