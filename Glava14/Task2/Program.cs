using System;
using System.Threading;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => CalculateSum("Thread 1", 1, 10));
            Thread thread2 = new Thread(() => CalculateSum("Thread 2", 1, 10));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Все потоки завершили выполнение.");
        }

        static void CalculateSum(string threadName, int start, int end)
        {
            DateTime startTime = DateTime.Now;

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            DateTime endTime = DateTime.Now;
            double elapsedTime = (endTime - startTime).TotalMilliseconds;
            Console.WriteLine($"{threadName}: Сумма чисел от {start} до {end} = {sum}, Время выполнения: {elapsedTime} мс");
        }
    }
}