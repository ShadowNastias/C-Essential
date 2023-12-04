namespace Lesson10.MyListExtensions;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        int[] array = myList.GetArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}