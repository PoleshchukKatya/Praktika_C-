using System;
namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число:");
        string input = Console.ReadLine(); 

        int number;

        if (int.TryParse(input, out number))
        {
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} является нечетным числом.");
            }
            else
            {
                Console.WriteLine($"{number} не является нечетным числом.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите целое число.");
        }

        Console.ReadLine(); 
    }
}
