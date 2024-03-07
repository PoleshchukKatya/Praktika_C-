using System;
namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        double A = Math.PI / 3;
        double B = 2 * Math.PI / 3; 
        int M = 20; 
        double H = (B - A) / M; 

        Console.WriteLine("Значения функции F(x) = cos(x) на отрезке [PI/3, 2PI/3]:");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double Fx = Math.Cos(x);
            Console.WriteLine($"F({x}) = {Fx}");
        }

        Console.ReadLine(); 
    }
}