using System;
namespace Task3_3_4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сиракузская последовательность для числа {n}:");
        Console.Write(n + " ");

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }
            Console.Write(n + " ");
        }
    }
}