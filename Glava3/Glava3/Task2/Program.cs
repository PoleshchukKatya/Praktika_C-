using System;
class Program
{
    static double CalculateFunctionValue(double x, double a)
    {
        if (x < a)
        {
            return 0;
        }
        else if (x > a)
        {
            return (x - a) / (x + a);
        }
        else 
        {
            return 1;
        }
    }

    static void CalculateFunctionValues(double a, double b, double h)
    {
        Console.WriteLine("x\t|\tf(x)");
        Console.WriteLine("---------------------");
        for (double x = a; x <= b; x += h)
        {
            double y = CalculateFunctionValue(x, a);
            Console.WriteLine($"{x}\t|\t{y}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение h:");
        double h = double.Parse(Console.ReadLine());

        CalculateFunctionValues(a, b, h);
    }
}
