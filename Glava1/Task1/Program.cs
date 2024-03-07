using System;
namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;

        if (x < 1.3)
        {
            y = Math.PI * x * x - (7 / Math.Sqrt(Math.Abs(x)));
        }
        else if (x == 1.3)
        {
            y = Math.PI * Math.Pow(x, 2) - (7 / Math.Sqrt(Math.Abs(x)));
        }
        else if (x > 1.3)
        {
            Console.WriteLine("Для данного значения x функция не определена.");
            return; 
        }

        Console.WriteLine($"Значение функции для x = {x}: {y}");
        Console.ReadLine();
    }
}
