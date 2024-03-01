using System;
namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три целых числа:");
        Console.Write("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третее число:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2 + num3;
        Console.WriteLine($"Сумма трёх чисел:{sum}");
        Console.ReadLine();
    }
}
