using System.Collections;

namespace Lesson14.MyDictionary;

public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private List<KeyValuePair<TKey, TValue>> _list = new List<KeyValuePair<TKey, TValue>>();

    public void Add(TKey key, TValue value)
    {
        // Перевіряємо, чи ключ уже існує в словнику
        foreach (var pair in _list)
        {
            if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
            {
                throw new ArgumentException("An item with the same key has already been added.");
            }
        }
        _list.Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public TValue this[TKey key]
    {
        get
        {
            foreach (var pair in _list)
            {
                if (EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                {
                    return pair.Value;
                }
            }
            throw new KeyNotFoundException();
        }
        set
        {
            bool updated = false;
            for (int i = 0; i < _list.Count; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(_list[i].Key, key))
                {
                    _list[i] = new KeyValuePair<TKey, TValue>(key, value);
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                _list.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
        }
    }

    public int Count => _list.Count;

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}