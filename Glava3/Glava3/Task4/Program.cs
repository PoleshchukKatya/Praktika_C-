using System;

class TwoDimensionalArray
{
    private int[,] array;

    public int[,] Array
    {
        get { return array; }
        set { array = value; }
    }

    public TwoDimensionalArray(int rows, int columns)
    {
        array = new int[rows, columns];
    }

    public int[,] Modulo(int divisor)
    {
        int[,] result = new int[array.GetLength(0), array.GetLength(1)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[i, j] = array[i, j] % divisor;
            }
        }

        return result;
    }

    public static TwoDimensionalArray operator +(TwoDimensionalArray array1, TwoDimensionalArray array2)
    {
        if (array1.array.GetLength(0) != array2.array.GetLength(0) || array1.array.GetLength(1) != array2.array.GetLength(1))
        {
            throw new ArgumentException("Размеры массивов должны совпадать для выполнения операции сложения.");
        }

        TwoDimensionalArray result = new TwoDimensionalArray(array1.array.GetLength(0), array1.array.GetLength(1));

        for (int i = 0; i < array1.array.GetLength(0); i++)
        {
            for (int j = 0; j < array1.array.GetLength(1); j++)
            {
                result.array[i, j] = array1.array[i, j] + array2.array[i, j];
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TwoDimensionalArray array1 = new TwoDimensionalArray(2, 3);
        array1.Array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        int[,] result = array1.Modulo(3);

        Console.WriteLine("Остатки от деления всех элементов массива на 3:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
 
        TwoDimensionalArray array2 = new TwoDimensionalArray(2, 3);
        array2.Array = new int[,] { { 1, 1, 1 }, { 1, 1, 1 } };

        TwoDimensionalArray sum = array1 + array2;

        Console.WriteLine("Результат сложения двух массивов:");
        for (int i = 0; i < sum.Array.GetLength(0); i++)
        {
            for (int j = 0; j < sum.Array.GetLength(1); j++)
            {
                Console.Write(sum.Array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}