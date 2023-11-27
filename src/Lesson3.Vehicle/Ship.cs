namespace Lesson3.Vehicle;

public class Ship : Vehicle
{
    public int Passengers { get; set; }
    public string HomePort { get; set; }

    public Ship(double latitude, double longitude, decimal price, float speed, int year, int passengers, string port)
        : base(latitude, longitude, price, speed, year)
    {
        Passengers = passengers;
        HomePort = port;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Passengers: {Passengers}, HomePort: {HomePort}");
    }
}