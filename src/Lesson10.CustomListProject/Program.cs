namespace Lesson10.CustomListProject
{
    class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            T[] newItems = new T[_count + 1];
            if (_items != null)
            {
                _items.CopyTo(newItems, 0);
            }

            newItems[_count] = item;
            _items = newItems;
            _count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }

                return _items[index];
            }
        }

        public int Count
        {
            get { return _count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine($"Елемент з індексом 1: {myList[1]}");
            Console.WriteLine($"Загальна кількість елементів: {myList.Count}");
        }
    }
}