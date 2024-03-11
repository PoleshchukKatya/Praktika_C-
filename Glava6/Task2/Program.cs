using System;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            int errors = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (IsPunctuation(text[i]) && text[i + 1] != ' ')
                {
                    errors++;
                }
            }

            Console.WriteLine($"Количество ошибок в тексте: {errors}");

            Console.ReadLine();
        }

        static bool IsPunctuation(char c)
        {
            char[] punctuation = { '.', ',', ';', ':', '!', '?' };

            foreach (char p in punctuation)
            {
                if (c == p)
                {
                    return true;
                }
            }

            return false;
        }
    }
}