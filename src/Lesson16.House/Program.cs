namespace Lesson16.House;

class Program
{
    static void Main()
    {
        House originalHouse = new House("123 Main St", 1000);
        House shallowCopy = originalHouse.Clone();
        House deepCopy = originalHouse.DeepClone();

        Console.WriteLine("Original house address: " + originalHouse.Address);
        Console.WriteLine("Shallow copy address: " + shallowCopy.Address);
        Console.WriteLine("Deep copy address: " + deepCopy.Address);

        originalHouse.Address = "456 Elm St";

        Console.WriteLine("After changing the original house address:");
        Console.WriteLine("Original house address: " + originalHouse.Address);
        Console.WriteLine("Shallow copy address: " + shallowCopy.Address);
        Console.WriteLine("Deep copy address: " + deepCopy.Address);
    }
}