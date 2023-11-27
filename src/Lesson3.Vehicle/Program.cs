namespace Lesson3.Vehicle;

class Program
{
    static void Main(string[] args)
    {
        var plane = new Plane(52.370216, 4.895168, 1000000m, 800f, 2020, 10000, 150);
        var car = new Car(48.856613, 2.352222, 30000m, 180f, 2019);
        var ship = new Ship(37.774929, -122.419416, 5000000m, 30f, 2015, 300, "San Francisco");

        plane.DisplayInfo();
        Console.WriteLine();
        car.DisplayInfo();
        Console.WriteLine();
        ship.DisplayInfo();
    }
}