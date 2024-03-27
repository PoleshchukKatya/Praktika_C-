using System;

namespace Task4
{
    /// <summary>
    /// Класс содержащий методы для работы с делегатами.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Делегат для генерации случайного числа.
        /// </summary>
        public delegate int RandomDelegate();

        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        public static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];

            Random rand = new Random();
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = delegate { return rand.Next(1, 100); };
            }

            Func<RandomDelegate[], double> average = delegate (RandomDelegate[] dels)
            {
                double sum = 0;
                foreach (var del in dels)
                {
                    sum += del();
                }
                return sum / dels.Length;
            };

            double avgResult = average(delegates);
            Console.WriteLine($"Среднее арифметическое: {avgResult}");

            Console.ReadLine();
        }
    }
}