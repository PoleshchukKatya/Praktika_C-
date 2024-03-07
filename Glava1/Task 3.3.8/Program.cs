using System;
namespace Task3_3_8;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел:");
        int n = int.Parse(Console.ReadLine());

        double[] numbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите число {i + 1}:");
            numbers[i] = double.Parse(Console.ReadLine());
        }
        double maxAbs = Math.Abs(numbers[0]);
        for (int i = 1; i < n; i++)
        {
            double abs = Math.Abs(numbers[i]);
            if (abs > maxAbs)
            {
                maxAbs = abs;
            }
        }
        Console.WriteLine($"Максимальный модуль числа: {maxAbs}");
    }
}