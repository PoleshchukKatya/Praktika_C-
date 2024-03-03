using System;
namespace Task8;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны квадрата:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double perimeter = 4 * sideLength;

        Console.WriteLine($"Периметр квадрата со стороной {sideLength} равен {perimeter}");
        Console.ReadLine(); 
    }
}