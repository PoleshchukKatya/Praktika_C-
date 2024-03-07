using System;
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] spiralArray = new int[7, 7];

            int num = 1;

            int top = 0, bottom = 6, left = 0, right = 6;

            while (num <= 49)
            {
                for (int i = left; i <= right; i++)
                {
                    spiralArray[top, i] = num++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    spiralArray[i, right] = num++;
                }
                right--;

                for (int i = right; i >= left; i--)
                {
                    spiralArray[bottom, i] = num++;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    spiralArray[i, left] = num++;
                }
                left++;
            }

            Console.WriteLine("Двумерный массив со значениями по спирали:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(spiralArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}