using System;

namespace Task3
{
    /// <summary>
    /// Класс содержащий методы для действий со строками.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Делегат для выполнения действий со строкой.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        public delegate void StringManipulation(string input);

        /// <summary>
        /// Метод для определения длины строки.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        public static void GetStringLength(string input)
        {
            Console.WriteLine($"Длина строки\"{input}\": {input.Length}");
        }

        /// <summary>
        /// Метод для преобразования строки к верхнему регистру.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        public static void ConvertToUpperCase(string input)
        {
            Console.WriteLine($"Строка в верхнем регистре: {input.ToUpper()}");
        }

        /// <summary>
        /// Метод для проверки строки на палиндром.
        /// </summary>
        /// <param name="input">Входная строка.</param>
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

        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
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