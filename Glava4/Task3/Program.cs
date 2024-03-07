using System;
namespace Task3
{
    class Program
    {
        static void Mean(double X, double Y, out double AMean, out double GMean)
        {
            if (X <= 0 || Y <= 0)
            {
                throw new ArgumentException("X и Y должны быть положительными числами.");
            }

            AMean = (X + Y) / 2;
            GMean = Math.Sqrt(X * Y);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение X:");
                double X = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите значение Y:");
                double Y = double.Parse(Console.ReadLine());

                double AMean, GMean;
                Mean(X, Y, out AMean, out GMean);

                Console.WriteLine($"Среднее арифметическое: {AMean}");
                Console.WriteLine($"Среднее геометрическое: {GMean}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата ввода. Введите число в допустимом формате.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}