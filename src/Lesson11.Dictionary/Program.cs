namespace Lesson11.Dictionary;

class Program
{
    static void Main()
    {
        var myDictionary = SimpleDictionary<string, int>.Create();
        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);

        Console.WriteLine("Count: " + myDictionary.Count);
        Console.WriteLine("Value for 'two': " + myDictionary["two"]);

        myDictionary["two"] = 22;
        Console.WriteLine("Updated value for 'two': " + myDictionary["two"]);
    }
}