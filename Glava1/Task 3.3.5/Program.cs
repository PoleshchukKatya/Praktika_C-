using System;
namespace Task3_3_5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        string numberStr = Console.ReadLine();
        string result = RemoveEvenDigits(numberStr);

        Console.WriteLine($"Число после удаления чётных цифр: {result}");
    }
    static string RemoveEvenDigits(string numberStr)
    {
        string result = "";
        foreach (char digit in numberStr)
        {
            int num = digit - '0'; 
            if (num % 2 != 0)
            {
                result += digit;
            }
        }
        return result;
    }
}