using System;
namespace Task3_3_6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        bool ordered = CheckDigitOrder(number);

        if (ordered)
        {
            Console.WriteLine("Цифры числа упорядочены по возрастанию справа налево.");
        }
        else
        {
            Console.WriteLine("Цифры числа не упорядочены по возрастанию справа налево.");
        }
    }

    static bool CheckDigitOrder(int number)
    {
        int lastDigit = number % 10;
        number /= 10;

        while (number > 0)
        {
            int currentDigit = number % 10;
            if (currentDigit >= lastDigit)
            {
                return false;
            }
            lastDigit = currentDigit;
            number /= 10;
        }

        return true;
    }
}