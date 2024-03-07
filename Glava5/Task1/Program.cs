using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Порядковые номера нечетных элементов массива:");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine($"Элемент с порядковым номером {i + 1} - {numbers[i]}");
                }
            }

            Console.ReadLine();
        }
    }
}