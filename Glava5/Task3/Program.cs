using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы (N):");
            int N = int.Parse(Console.ReadLine());

            if (N >= 10)
            {
                Console.WriteLine("Размерность матрицы должна быть меньше 10.");
                return;
            }

            Console.WriteLine("Введите минимальное значение (a):");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение (b):");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите нижнюю границу промежутка (C):");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите верхнюю границу промежутка (D):");
            int D = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(a, b + 1);
                }
            }

            Console.WriteLine("\nИсходная матрица:");
            PrintMatrix(matrix);

            int product = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int value = matrix[i, j];
                    if (value >= C && value <= D)
                    {
                        product *= value;
                    }
                }
            }
            Console.WriteLine($"\nПроизведение чисел, принадлежащих промежутку [{C}, {D}]: {product}");

            Console.WriteLine("\nСумма элементов каждого столбца:");
            for (int j = 0; j < N; j++)
            {
                int sum = 0;
                for (int i = 0; i < N; i++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine($"Сумма элементов столбца {j + 1}: {sum}");
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}