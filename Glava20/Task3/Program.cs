using System;
using System.Threading.Tasks;
namespace Task3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task<Tuple<int, int>> firstTask = Task.Run(() =>
            {
                int number = 345;
                int firstDigit = number / 100; 
                int lastDigit = number % 10; 
                return Tuple.Create(firstDigit, lastDigit);
            });

            Task continuationTask = firstTask.ContinueWith(task =>
            {
                Tuple<int, int> result = task.Result;
                Console.WriteLine($"Первая цифра: {result.Item1}, Последняя цифра: {result.Item2}");
            });

            await continuationTask;
        }
    }
}