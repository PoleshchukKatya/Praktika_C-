using System;
using System.IO;
namespace Task1
{
    class Program
    {
        static void Main()
        {
            double[] numbers = { 3.14, 2.718, 1.618, -4.5, 6.0 };

            string filePath = "numbers.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (double number in numbers)
                {
                    writer.WriteLine(number);
                }
            }

            string[] lines = File.ReadAllLines(filePath);

            double sum = 0;
            double product = 1;

            foreach (string line in lines)
            {
                double num = double.Parse(line);
                sum += num;
                product *= num;
            }

            double sumModule = Math.Abs(sum);
            double productSquare = Math.Pow(product, 2);

            Console.WriteLine("Модуль суммы: " + sumModule);
            Console.WriteLine("Квадрат произведения: " + productSquare);
        }
    }
}