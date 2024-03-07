using System;
namespace Task5
{
    class Program
    {
        static double Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static double CalculateFunction(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            return 1.0 / Factorial(n + 1);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение n:");
                int n = int.Parse(Console.ReadLine());

                double result = CalculateFunction(n);
                Console.WriteLine($"f({n}) = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода числа.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}