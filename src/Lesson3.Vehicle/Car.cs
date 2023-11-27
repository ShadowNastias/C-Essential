namespace Lesson3.Vehicle;

public class Car : Vehicle
{
    public Car(double latitude, double longitude, decimal price, float speed, int year)
        : base(latitude, longitude, price, speed, year)
    {
    }
}