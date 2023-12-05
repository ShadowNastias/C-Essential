namespace Lesson11.Dictionary;

class SimpleDictionary<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> _dictionary;

    private SimpleDictionary()
    {
        _dictionary = new Dictionary<TKey, TValue>();
    }

    public static SimpleDictionary<TKey, TValue> Create()
    {
        return new SimpleDictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        _dictionary.Add(key, value);
    }

    public TValue this[TKey key]
    {
        get
        {
            if (!_dictionary.ContainsKey(key))
            {
                throw new KeyNotFoundException($"The key '{key}' was not found in the dictionary.");
            }
            return _dictionary[key];
        }
        set => _dictionary[key] = value;
    }

    public int Count => _dictionary.Count;
}