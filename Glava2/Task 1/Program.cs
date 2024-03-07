using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A(5, 10);

            objA.DisplayInfo();
            Console.WriteLine($"Произведение a и b: {objA.Multiply()}");
            Console.WriteLine($"Значение выражения √b / (2 * a): {objA.CalculateExpression()}");
        }
    }
}