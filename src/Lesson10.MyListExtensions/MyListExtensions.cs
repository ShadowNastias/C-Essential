namespace Lesson10.MyListExtensions;

public static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        return list.ToArray();
    }
}