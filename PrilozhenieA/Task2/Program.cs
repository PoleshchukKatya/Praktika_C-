using System;
namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digit1 = number % 10;
        int digit2 = (number / 10) % 10;
        int digit3 = number / 100;
        int reversedNumber = digit1 * 100 + digit2 * 10 + digit3;
        Console.WriteLine($"Число, полученное при прочтение цифр справа налево: {reversedNumber}");
        Console.ReadLine();
    }
}
