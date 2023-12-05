namespace Lesson11.CarCollection;

class Car
{
    public string Name { get; private set; }
    public int Year { get; private set; }

    public Car(string name, int year)
    {
        Name = name;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Name} - {Year}";
    }
}