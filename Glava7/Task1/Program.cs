using System;
using System.Text.RegularExpressions;
namespace Task1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b\w*[аеёиоуыэюя]+[аеёиоуыэюя]+\b", RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Слова, оканчивающиеся на несколько подряд идущих гласных:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();
        }
    }
}