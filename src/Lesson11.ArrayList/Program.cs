namespace Lesson11.ArrayList;

class Program
{
    static void Main(string[] args)
    {
        var arrayList = new ArrayList();
        arrayList.Add("Hello");
        arrayList.Add("World");
        arrayList.Add(123);

        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine(arrayList[i]);
        }
    }
}