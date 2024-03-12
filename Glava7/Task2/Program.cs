using System;
using System.Text.RegularExpressions;
namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', ',', ':', ';', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> seenWords = new HashSet<string>();
            HashSet<string> repeatedWords = new HashSet<string>(); 

            foreach (string word in words)
            {
                if (!seenWords.Add(word)) 
                {
                    repeatedWords.Add(word); 
                }
            }

            if (repeatedWords.Count > 0)
            {
                Console.WriteLine("Повторяющиеся слова в тексте:");
                foreach (string word in repeatedWords)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("В тексте нет повторяющихся слов.");
            }

            Console.ReadKey();
        }
    }
}