namespace Lesson14.EnumerableExtensions;

class Program
{
    static void Main()
    {
        var myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        int[] array = myList.GetArray();
        Console.WriteLine("Elements in the array:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}