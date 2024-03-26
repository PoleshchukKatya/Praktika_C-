using System;
using System.Collections.Generic;
namespace Task1
{
    class Program
    {
        static string ProcessString(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            char[] resultArray = stack.ToArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с символами #:");
            string input = Console.ReadLine();
            string result = ProcessString(input);
            Console.WriteLine("Исходная строка: " + input);
            Console.WriteLine("Результирующая строка: " + result);
        }
    }
}