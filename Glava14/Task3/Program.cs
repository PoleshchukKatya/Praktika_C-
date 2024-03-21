using System;
using System.Threading;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение N:");
            int N = int.Parse(Console.ReadLine());

            object lockObject = new object();

            Thread thread1 = new Thread(() => APlusAPowerN(A, N));
            thread1.Start();

            AMultipliedByN(A, N, lockObject);

            thread1.Join();

            Console.WriteLine("Все потоки завершили выполнение.");
        }

        static void APlusAPowerN(int A, int N)
        {
            long sum = 0;
            for (int i = 0; i <= N; i++)
            {
                sum += (long)Math.Pow(A, i);
            }
            Console.WriteLine($"Сумма A + A^1 + A^2 + ... + A^N для A={A} и N={N}: {sum}");
        }

        static void AMultipliedByN(int A, int N, object lockObject)
        {
            long product = 1;
            for (int i = 1; i <= N; i++)
            {
                product *= (long)Math.Pow(A, i);
            }
            lock (lockObject)
            {
                Console.WriteLine($"Произведение A * A^1 * A^2 * ... * A^N для A={A} и N={N}: {product}");
            }
        }
    }
}