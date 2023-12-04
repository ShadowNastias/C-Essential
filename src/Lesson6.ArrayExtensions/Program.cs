namespace Lesson6.ArrayExtensions;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

        array.SortAscending();

        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
    }
}