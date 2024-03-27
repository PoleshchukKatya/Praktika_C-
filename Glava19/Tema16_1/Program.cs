using System;
using System.IO;
namespace Task16_1
{
    /// <summary>
    /// Класс для работы с числами.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Основной метод программы.
        /// </summary>
        static void Main()
        {
            // Массив чисел
            double[] numbers = { 3.14, 2.718, 1.618, -4.5, 6.0 };

            string filePath = "numbers.txt";

            // Запись чисел в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (double number in numbers)
                {
                    writer.WriteLine(number);
                }
            }

            // Чтение чисел из файла
            string[] lines = File.ReadAllLines(filePath);

            double sum = 0;
            double product = 1;

            // Вычисление суммы и произведения чисел
            foreach (string line in lines)
            {
                double num = double.Parse(line);
                sum += num;
                product *= num;
            }

            // Вычисление модуля суммы и квадрата произведения
            double sumModule = Math.Abs(sum);
            double productSquare = Math.Pow(product, 2);

            // Вывод результатов
            Console.WriteLine("Модуль суммы: " + sumModule);
            Console.WriteLine("Квадрат произведения: " + productSquare);
        }
    }
}