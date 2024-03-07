using System;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = 18;
            int monthsCount = 12;

            double[,] salaries = new double[peopleCount, monthsCount];

            Random random = new Random();
            for (int i = 0; i < peopleCount; i++)
            {
                for (int j = 0; j < monthsCount; j++)
                {
                    salaries[i, j] = random.Next(1000, 5001);
                }
            }

            Console.WriteLine("Исходный двумерный массив зарплат:");
            PrintArray(salaries);

            double yearlyIncome = 0;
            for (int j = 0; j < monthsCount; j++)
            {
                yearlyIncome += salaries[0, j];
            }

            double threshold = 100000; 
            bool isYearlyIncomeGreater = yearlyIncome > threshold;

            if (isYearlyIncomeGreater)
            {
                Console.WriteLine($"Годовой доход первого человека ({yearlyIncome}) больше {threshold}");
            }
            else
            {
                Console.WriteLine($"Годовой доход первого человека ({yearlyIncome}) не больше {threshold}");
            }
        }

        static void PrintArray(double[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j],8:N2}");
                }
                Console.WriteLine();
            }
        }
    }
}