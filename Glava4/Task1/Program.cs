using System;
namespace Task1
{

    class Program
    {
        static double ExpressionA(double x)
        {
            return (Math.Pow(x, 3) - 2) / (x + 10) + 4 * x;
        }

        static double ExpressionB(double x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("Аргумент логарифма должен быть положительным числом.");
            }

            return Math.Log(x) + (Math.Cos(x) / (x + 6));
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение x для вычисления выражения A:");
                double xA = double.Parse(Console.ReadLine());
                double resultA = ExpressionA(xA);
                Console.WriteLine($"Значение выражения A для x = {xA}: {resultA}");

                Console.WriteLine("Введите значение x для вычисления выражения B:");
                double xB = double.Parse(Console.ReadLine());
                double resultB = ExpressionB(xB);
                Console.WriteLine($"Значение выражения B для x = {xB}: {resultB}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат ввода данных.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.ReadLine();
        }
    }
}