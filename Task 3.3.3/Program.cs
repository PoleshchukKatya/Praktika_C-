using System;
namespace Task3_3_3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите цифру k:");
        int k = int.Parse(Console.ReadLine());

        int count = CountDigit(n, k);

        Console.WriteLine($"Цифра {k} встречается в числе {n} {count} раз(а).");
        Console.ReadLine(); 
    }

    static int CountDigit(int n, int k)
    {
        int count = 0;
        while (n > 0)
        {
            int digit = n % 10; 
            if (digit == k)
            {
                count++; 
            }
            n /= 10; 
        }
        return count;
    }
}