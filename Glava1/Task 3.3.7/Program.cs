using System;
namespace Task3_3_7;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int n = int.Parse(Console.ReadLine());
        int divisorsCount = CountDivisors(n);
        Console.WriteLine($"Количество делителей числа {n}: {divisorsCount}");
    }
    static int CountDivisors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        return count;
    }
}