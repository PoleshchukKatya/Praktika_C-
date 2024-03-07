using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine("Информация о треугольнике:");
            triangle.DisplayInfo();

            triangle.Move(2, 3);

            triangle.Resize(1.5);

            triangle.Rotate(45);

            Console.WriteLine("Обновленная информация о треугольнике:");
            triangle.DisplayInfo();
            Console.ReadLine();
        }
    }
}