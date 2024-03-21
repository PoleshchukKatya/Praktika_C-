using System;
using System.Threading;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            AutoResetEvent firstThreadReady = new AutoResetEvent(false);
            AutoResetEvent secondThreadReady = new AutoResetEvent(false);
            AutoResetEvent thirdThreadReady = new AutoResetEvent(false);

            Thread firstThread = new Thread(() => PrintNumbers(0, 10, firstThreadReady, secondThreadReady));
            Thread secondThread = new Thread(() => PrintNumbers(10, 20, secondThreadReady, thirdThreadReady));
            Thread thirdThread = new Thread(() => PrintNumbers(20, 30, thirdThreadReady, firstThreadReady));

            firstThread.Priority = ThreadPriority.Lowest;
            secondThread.Priority = ThreadPriority.Normal;
            thirdThread.Priority = ThreadPriority.Highest;

            firstThread.Start();
            secondThread.Start();
            thirdThread.Start();

            firstThreadReady.Set();

            firstThread.Join();
            secondThread.Join();
            thirdThread.Join();

            Console.WriteLine("Все потоки завершили выполнение.");
        }

        static void PrintNumbers(int start, int end, AutoResetEvent currentThreadReady, AutoResetEvent nextThreadReady)
        {
            for (int i = start; i < end; i++)
            {
                currentThreadReady.WaitOne();
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: {i}");

                nextThreadReady.Set();

                Thread.Sleep(100);
            }
        }
    }
}