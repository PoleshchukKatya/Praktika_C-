using System;
namespace Task12_1
{
    /// <summary>
    /// Делегат для вычисления характеристик фигуры.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Значение характеристики фигуры.</returns>
    public delegate double CalcFigure(double radius);

    /// <summary>
    /// Класс содержащий методы для вычисления характеристик фигур.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод для вычисления длины окружности по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        public static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        public static double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Метод для вычисления объема шара по радиусу.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        public static double Get_Volume(double radius)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine("Длина окружности: " + CF(radius));

            CF = Get_Area;
            Console.WriteLine("Площадь круга: " + CF(radius));

            CF = Get_Volume;
            Console.WriteLine("Объем шара: " + CF(radius));
        }
    }
}