using System;
namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        double x = 0.7;
        double ePowerX = Math.Exp(x);
        double cosEPowerX = Math.Cos(ePowerX);

        double firstTerm = 20 * Math.Log(Math.Abs(cosEPowerX));
        double secondTerm = Math.Pow(Math.Sin(Math.PI), 3) + Math.Abs(1 - x * x);
        double lastTerm = 2 / Math.Sqrt(secondTerm);

        double y = firstTerm - lastTerm;
        Console.WriteLine($"Значение функции для x = 0.7: {y}");

        Console.ReadLine();
    }
}