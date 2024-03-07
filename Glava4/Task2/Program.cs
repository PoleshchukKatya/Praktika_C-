using System;
namespace Task2
{
    class Program
    {
        static double CalculateFunction(double x)
        {
            if (x > 0 && x < 1)
            {
                return 3 * Math.Pow(x, 2);
            }
            else if (x >= 1)
            {
                if (Math.Abs(x - 1) < double.Epsilon)
                {
                    throw new DivideByZeroException("Деление на ноль. Попытка вычисления значения функции в точке x = 1.");
                }
                return x / (x - 1);
            }
            else
            {
                throw new ArgumentOutOfRangeException("x", "Аргумент x выходит за допустимый диапазон.");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение x:");
                double x = double.Parse(Console.ReadLine());

                double result = CalculateFunction(x);
                Console.WriteLine($"Значение функции f(x) при x = {x} равно {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата ввода. Введите число в допустимом формате.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}