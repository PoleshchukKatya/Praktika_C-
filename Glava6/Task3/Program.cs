using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            string firstWord = words[0];
            string lastWord = words[words.Length - 1];
            words[0] = lastWord;
            words[words.Length - 1] = firstWord;
            string result1 = string.Join(" ", words);

            string result2 = words[1] + words[2];

            string thirdWord = words.Length >= 3 ? words[2] : "";
            char[] thirdWordChars = thirdWord.ToCharArray();
            Array.Reverse(thirdWordChars);
            string result3 = new string(thirdWordChars);

            string firstWordModified = firstWord.Length > 2 ? firstWord.Substring(2) : "";

            Console.WriteLine("Результаты:");
            Console.WriteLine("Предложение с поменянными первым и последним словами: " + result1);
            Console.WriteLine("Склеенные второе и третье слова: " + result2);
            Console.WriteLine("Третье слово в обратном порядке: " + result3);
            Console.WriteLine("Первое слово с удаленными первыми двумя буквами: " + firstWordModified);
            Console.ReadLine();
        }
    }
}