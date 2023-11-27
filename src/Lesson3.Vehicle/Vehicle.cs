namespace Lesson3.Vehicle;

public class Vehicle
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public decimal Price { get; set; }
    public float Speed { get; set; }
    public int YearOfManufacture { get; set; }

    public Vehicle(double latitude, double longitude, decimal price, float speed, int year)
    {
        Latitude = latitude;
        Longitude = longitude;
        Price = price;
        Speed = speed;
        YearOfManufacture = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Coordinates: {Latitude}, {Longitude}");
        Console.WriteLine($"Price: {Price}, Speed: {Speed}, Year: {YearOfManufacture}");
    }
}