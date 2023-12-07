namespace Lesson17.Car;

class Customer
{
    public string CarModel { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Customer(string carModel, string name, string phoneNumber)
    {
        CarModel = carModel;
        Name = name;
        PhoneNumber = phoneNumber;
    }
}