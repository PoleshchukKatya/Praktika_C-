using System;
namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите радиус основания цилиндра: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите высоту цилиндра: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double sideArea = 2 * Math.PI * radius * height;

        double baseArea = Math.PI * Math.Pow(radius, 2);

        double generalArea = 2 * sideArea + 2 * baseArea;

        Console.WriteLine($"Площадь поверхности цилиндра: {generalArea}");
        Console.ReadLine();
    }
}
