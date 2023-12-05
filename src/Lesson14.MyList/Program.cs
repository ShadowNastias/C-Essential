namespace Lesson14.MyList;

class Program
{
    static void Main(string[] args)
    {
        var myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        Console.WriteLine("Elements in MyList:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Element at index 1: {myList[1]}");
        Console.WriteLine($"Total elements: {myList.Count}");
    }
}