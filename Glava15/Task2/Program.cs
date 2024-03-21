using System;
using System.Collections.Generic;
namespace Task2
{
    class MyDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _pairs;

        public MyDictionary()
        {
            _pairs = new List<KeyValuePair<TKey, TValue>>();
        }
        public void Add(TKey key, TValue value)
        {
            _pairs.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
        public TValue this[TKey key]
        {
            get
            {
                foreach (var pair in _pairs)
                {
                    if (pair.Key.Equals(key))
                        return pair.Value;
                }
                throw new KeyNotFoundException($"Ключ '{key}' не найден.");
            }
        }
        public int Count
        {
            get { return _pairs.Count; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Один", 1);
            myDictionary.Add("Два", 2);
            myDictionary.Add("Три", 3);

            Console.WriteLine("Общее количество пар: " + myDictionary.Count);
            Console.WriteLine("Значение для ключа 'Один': " + myDictionary["Один"]);
            Console.WriteLine("Значение для ключа 'Два': " + myDictionary["Два"]);
            Console.WriteLine("Значение для ключа 'Три': " + myDictionary["Три"]);
        }
    }
}