namespace Lesson11.ArrayList;

public class ArrayList
{
    private object[] _items;
    private int _size;

    public ArrayList()
    {
        _items = new object[4];
        _size = 0;
    }

    public object this[int index] 
    { 
        get { return _items[index]; }
        set { _items[index] = value; }
    }

    public int Count => _size;

    public void Add(object item)
    {
        if (_size == _items.Length)
        {
            Resize();
        }

        _items[_size] = item;
        _size++;
    }

    private void Resize()
    {
        int newSize = _items.Length * 2;
        object[] newArray = new object[newSize];
        Array.Copy(_items, newArray, _items.Length);
        _items = newArray;
    }
}