using System.Collections;

namespace Lesson14.MyList;

public class MyList<T> : IEnumerable<T>
{
    private T[] _items;
    private int _size;

    public MyList()
    {
        _items = new T[0];
    }

    public void Add(T item)
    {
        if (_size == _items.Length)
        {
            int newLength = _size == 0 ? 4 : _size * 2;
            T[] newArray = new T[newLength];
            _items.CopyTo(newArray, 0);
            _items = newArray;
        }

        _items[_size] = item;
        _size++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _size)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _items[index];
        }
        set
        {
            if (index < 0 || index >= _size)
            {
                throw new ArgumentOutOfRangeException();
            }
            _items[index] = value;
        }
    }

    public int Count
    {
        get { return _size; }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _size; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}