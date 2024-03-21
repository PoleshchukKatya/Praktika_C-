using System;
using System.Threading;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int threadCount = 4;
            int[] partialSums = new int[threadCount];

            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() => CalculatePartialSum(numbers, threadCount, threadIndex, partialSums));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            int totalSum = 0;
            foreach (var partialSum in partialSums)
            {
                totalSum += partialSum;
            }

            Console.WriteLine($"Общая сумма четных чисел: {totalSum}");
        }

        static void CalculatePartialSum(int[] numbers, int threadCount, int threadIndex, int[] partialSums)
        {
            int partialSum = 0;
            for (int i = threadIndex; i < numbers.Length; i += threadCount)
            {
                if (numbers[i] % 2 == 0)
                {
                    partialSum += numbers[i];
                }
            }
            partialSums[threadIndex] = partialSum;
        }
    }
}