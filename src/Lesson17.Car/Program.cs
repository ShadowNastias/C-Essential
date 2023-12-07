namespace Lesson17.Car;

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Toyota", "Corolla", 2020, "Black"),
            new Car("Ford", "Focus", 2019, "White"),
            new Car("Honda", "Civic", 2021, "Grey")
        };

        List<Customer> customers = new List<Customer>
        {
            new Customer("Corolla", "John Doe", "+1234567890"),
            new Customer("Focus", "Jane Smith", "+0987654321"),
            new Customer("Civic", "Alice Johnson", "+1122334455")
        };

        var query = from car in cars
            join customer in customers on car.Model equals customer.CarModel
            select new
            {
                Car = car,
                Customer = customer
            };

        var selectedCarInfo = query.FirstOrDefault(info => info.Car.Model == "Corolla");
        if (selectedCarInfo != null)
        {
            Console.WriteLine($"Car: {selectedCarInfo.Car.Brand} {selectedCarInfo.Car.Model}, " +
                              $"Year: {selectedCarInfo.Car.Year}, Color: {selectedCarInfo.Car.Color}");
            Console.WriteLine($"Customer: {selectedCarInfo.Customer.Name}, " +
                              $"Phone: {selectedCarInfo.Customer.PhoneNumber}");
        }
        else
        {
            Console.WriteLine("Car not found.");
        }
    }
}