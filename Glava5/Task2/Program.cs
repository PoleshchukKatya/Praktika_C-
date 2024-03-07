using System;
namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[100];

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 101);
                Console.Write(numbers[i] + " ");
            }

            Array.Sort(numbers);

            Console.WriteLine("\nОтрицательные числа:");

            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine("\n\nПоложительные числа:");

            foreach (int num in numbers)
            {
                if (num >= 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine("\n\nВведите число для бинарного поиска:");
            int k = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(numbers, k);

            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено в массиве на позиции {index}");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено в массиве");
            }

            Console.ReadLine();
        }
    }
}