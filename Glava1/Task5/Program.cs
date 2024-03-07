using System;
namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число N:");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= N; i++)
        {
            sum += (2 * i - 1);
            Console.WriteLine($"Текущая сумма для {i} = {sum}");
        }

        Console.ReadLine();
    }
}