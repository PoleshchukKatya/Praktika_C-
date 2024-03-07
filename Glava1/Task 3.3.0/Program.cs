using System;
namespace Task3_3_0;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int minDigit = 9;
        int maxDigit = 0; 

        int tempNumber = number; 

        while (tempNumber > 0)
        {
            int digit = tempNumber % 10;

            if (digit < minDigit)
            {
                minDigit = digit;
            }
            if (digit > maxDigit)
            {
                maxDigit = digit;
            }

            tempNumber /= 10; // 
        }

        Console.WriteLine($"Наименьшая цифра: {minDigit}");
        Console.WriteLine($"Наибольшая цифра: {maxDigit}");
        Console.ReadLine();
    }
}