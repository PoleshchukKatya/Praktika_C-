using System;
using System.Threading.Tasks;
namespace Task1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() =>
            {
                int number = 1234;
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine($"Сумма цифр: {sum}");
            });

            Task task2 = new Task(() =>
            {
                int number = 1234;
                int product = 1;
                while (number != 0)
                {
                    product *= number % 10;
                    number /= 10;
                }
                Console.WriteLine($"Произведение цифр: {product}");
            });
            task2.Start();

            Task task3 = Task.Factory.StartNew(() =>
            {
                int number = 123;
                int reversedNumber = 0;
                while (number != 0)
                {
                    reversedNumber = reversedNumber * 10 + number % 10;
                    number /= 10;
                }
                Console.WriteLine($"Число, полученное при прочтении его цифр справа налево: {reversedNumber}");
            });

            await Task.WhenAll(task1, task2, task3);
        }
    }
}