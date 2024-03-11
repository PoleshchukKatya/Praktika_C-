using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (frequencyMap.ContainsKey(c))
                {
                    frequencyMap[c]++;
                }
                else
                {
                    frequencyMap[c] = 1;
                }
            }

            Console.WriteLine("Частота каждого символа в тексте:");
            foreach (KeyValuePair<char, int> entry in frequencyMap)
            {
                Console.WriteLine($"Символ '{entry.Key}': {entry.Value}");
            }

            Console.ReadLine();
        }
    }
}
