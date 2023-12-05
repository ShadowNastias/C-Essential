namespace Lesson14.EnumerableExtensions;

public static class EnumerableExtensions
{
    public static T[] GetArray<T>(this IEnumerable<T> list)
    {
        var count = 0;
        foreach (var item in list)
        {
            count++;
        }

        var array = new T[count];
        var index = 0;
        foreach (var item in list)
        {
            array[index++] = item;
        }

        return array;
    }
}