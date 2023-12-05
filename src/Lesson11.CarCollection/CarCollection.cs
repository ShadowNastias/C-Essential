namespace Lesson11.CarCollection;

class CarCollection
{
    private List<Car> _cars = new List<Car>();

    public void AddCar(string name, int year)
    {
        _cars.Add(new Car(name, year));
    }

    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < _cars.Count)
            {
                return _cars[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Невірний індекс");
            }
        }
    }

    public int Count
    {
        get { return _cars.Count; }
    }

    public void Clear()
    {
        _cars.Clear();
    }
}