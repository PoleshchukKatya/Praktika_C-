using System;
using System.Threading.Tasks;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = -7;
            double B = 3;

            Parallel.For((int)A, (int)B + 1, i =>
            {
                double x = i;
                double result = Math.Cos(x);
                Console.WriteLine($"Значение Cos({x}) = {result}");
            });
        }
    }
}