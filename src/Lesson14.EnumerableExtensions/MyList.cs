namespace Lesson14.EnumerableExtensions;

public class MyList<T> : IEnumerable<T>
{
    private T[] _items = new T[0];
    private int _size;

    public void Add(T item)
    {
        if (_size == _items.Length)
        {
            int newLength = _size == 0 ? 4 : _size * 2;
            T[] newArray = new T[newLength];
            Array.Copy(_items, newArray, _size);
            _items = newArray;
        }

        _items[_size++] = item;
    }

    public int Count => _size;

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _size; i++)
        {
            yield return _items[i];
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}