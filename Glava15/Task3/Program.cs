using System;
namespace Task3
{
    public class MyList<T>
    {
        private T[] _items;
        private int _size;

        public MyList()
        {
            _items = new T[4];
            _size = 0;
        }
        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_size] = item;
            _size++;
        }
        public T this[int index]
        {
            get { return _items[index]; }
        }
        public int Count
        {
            get { return _size; }
        }
    }
    public static class MyListExtensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
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

            int[] array = myList.GetArray();

            Console.WriteLine("Значения в массиве:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}