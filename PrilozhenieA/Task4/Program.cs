using System;
namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину окружности: ");
        double lenght = Convert.ToDouble(Console.ReadLine());
        double radius = lenght / (2 * Math.PI);
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площать круга, ограниченная окружностью: {area}");
        Console.ReadLine();
    }
}
