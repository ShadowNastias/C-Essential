using Lesson18.MyNamespace;

namespace Lesson18.MyDictionary;

public class Program
{
    static void Main()
    {
        var myDictionary = new MyDictionary<string, int>();
        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);

        Console.WriteLine("Elements in MyDictionary:");
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        Console.WriteLine($"Value for key 'two': {myDictionary["two"]}");
        myDictionary.Remove("two");
        Console.WriteLine($"Element with key 'two' removed.");
        Console.WriteLine($"Total elements: {myDictionary.Count}");
    }
}