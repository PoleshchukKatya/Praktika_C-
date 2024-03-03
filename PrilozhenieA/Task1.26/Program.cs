using System;
namespace Task9;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус окружности:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double diameter = 2 * radius;

        Console.WriteLine($"Диаметр окружности с радиусом {radius} равен {diameter}");
        Console.ReadLine();
    }
}