using System;
using System.Threading;
using System.Threading.Tasks;
namespace Task2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task<double>[] tasks = new Task<double>[2];

            tasks[0] = Task.Run(() =>
            {
                double a = Math.PI / 9;
                double z1 = Math.Sin(4 * a) / (1 + Math.Cos(4 * a)) * Math.Cos(2 * a) / (1 + Math.Cos(2 * a));
                return z1;
            });

            tasks[1] = Task.Run(() =>
            {
                double a = Math.PI / 6; 
                double z2 = 1 / Math.Tan(3.0 / (2 * Math.PI - a));
                return z2;
            });

            await Task.WhenAll(tasks);

            Console.WriteLine("Результаты всех задач:");

            foreach (var task in tasks)
            {
                await task.ContinueWith(t => Console.WriteLine($"Результат: {t.Result}"));
            }

            Task<double> firstTask = await Task.WhenAny(tasks);
            Console.WriteLine($"Результат первой завершившейся задачи: {await firstTask}");
        }
    }
}