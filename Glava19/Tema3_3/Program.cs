using System;
namespace Task3_3
{
    class Program
    {
        /// <summary>
        /// Функция для вычисления значения функции для заданных x и a.
        /// </summary>
        /// <param name="x">Аргумент функции. </param>
        /// <param name="a">Параметр функции. </param>
        /// <param name="y">Возращаемое значение функции. </param>
        static void f(double x, double a, out double y)
        {
            if (x < a)
            {
                y = 0;
            }
            else if (x > a)
            {
                y = (x - a) / (x + a);
            }
            else
            {
                y = 1;
            }
        }

        /// <summary>
        /// Функция для построения таблицы значений функции на заданном промежутке.
        /// </summary>
        /// <param name="a">Начальное значение промежутка. </param>
        /// <param name="b">Конечное значение промежутка. </param>
        /// <param name="h">Шаг изменения </param>
        static void BuildTable(double a, double b, double h)
        {
            Console.WriteLine("x\t|\ty");
            Console.WriteLine("----------------------");
            for (double x = a; x <= b; x += h)
            {
                double y;
                f(x, a, out y);
                Console.WriteLine($"{x}\t|\t{y}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите h:");
            double h = double.Parse(Console.ReadLine());

            BuildTable(a, b, h);
            Console.ReadLine();
        }
    }
}