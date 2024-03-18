using System;
namespace Task3
{ 
    public class Program
    {
        public delegate void StringManipulation(string input);

        public static void GetStringLength(string input)
        {
            Console.WriteLine($"Длина строки \"{input}\": {input.Length}");
        }

        public static void ConvertToUpperCase(string input)
        {
            Console.WriteLine($"Строка в верхнем регистре: {input.ToUpper()}");
        }

        public static void CheckPalindrome(string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            if (input.ToLower() == reversed.ToLower())
            {
                Console.WriteLine($"Строка \"{input}\" является палиндромом.");
            }
            else
            {
                Console.WriteLine($"Строка \"{input}\" не является палиндромом.");
            }
        }

        public static void Main(string[] args)
        {
            StringManipulation? manipulator = null;

            manipulator += GetStringLength;
            manipulator += ConvertToUpperCase;
            manipulator += CheckPalindrome;

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            manipulator(input);
        }
    }
}