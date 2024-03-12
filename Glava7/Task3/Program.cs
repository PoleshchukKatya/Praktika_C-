using System;
using System.Text.RegularExpressions;
namespace Task3
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("Введите минимальное количество слов в предложении:");
            int minWords = int.Parse(Console.ReadLine());

            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentence in sentences)
            {
                if (CountWords(sentence) >= minWords)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

            Console.ReadKey();
        }

        static int CountWords(string sentence)
        {
            string[] words = Regex.Split(sentence, @"\W+"); 
            return words.Length;
        }
    }
}