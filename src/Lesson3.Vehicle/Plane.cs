namespace Lesson3.Vehicle;

public class Plane : Vehicle
{
    public int Altitude { get; set; }
    public int Passengers { get; set; }

    public Plane(double latitude, double longitude, decimal price, float speed, int year, int altitude, int passengers)
        : base(latitude, longitude, price, speed, year)
    {
        Altitude = altitude;
        Passengers = passengers;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Altitude: {Altitude}, Passengers: {Passengers}");
    }
}