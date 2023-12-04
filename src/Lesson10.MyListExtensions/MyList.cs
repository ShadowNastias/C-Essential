namespace Lesson10.MyListExtensions;

public class MyList<T>
{
    private List<T> _list = new List<T>();

    public void Add(T item)
    {
        _list.Add(item);
    } 
    
    public T[] ToArray()
    {
        return _list.ToArray();
    }
}