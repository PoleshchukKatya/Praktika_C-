using System;
namespace Task3_2
{
    class Program
    {
        /// <summary>
        /// Функция для вычисления значения функции для заданных x и a. 
        /// </summary>
        /// <param name="x">Аргумент функции. </param>
        /// <param name="a">Параметр функции. </param>
        /// <returns>Значение функции.</returns>
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

        /// <summary>
        /// Функция для вычисления значений функции на заданном промежутке.
        /// </summary>
        /// <param name="a">Начальное значение промежутка. </param>
        /// <param name="b">Конечное значение промежутка. </param>
        /// <param name="h">Шаг изменения. </param>
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
}