using System;
namespace Task6;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int firstDigit = number / 100;
        int lastDigit = number % 10;

        Console.WriteLine($"Первая цифра: {firstDigit}");
        Console.WriteLine($"Последняя цифра: {lastDigit}");
        Console.ReadLine();
    }
}
