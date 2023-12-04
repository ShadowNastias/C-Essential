namespace Lesson7.Notebook;
struct Notebook
{
    public string Model;
    public string Manufacturer;
    public decimal Cost;

    public Notebook(string model, string manufacturer, decimal cost)
    {
        Model = model;
        Manufacturer = manufacturer;
        Cost = cost;
    }

    public void Display()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Cost: {Cost}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Notebook myNotebook = new Notebook("ModelX", "BrandY", 1234.56m);
        myNotebook.Display();
    }
}