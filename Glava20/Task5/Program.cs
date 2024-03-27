using System;
using System.Threading.Tasks;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 54, 17, 25, 66 };

            Parallel.ForEach(numbers, (n, state) =>
            {
                long sum = 0;
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                }

                long product = 1;
                for (int i = 1; i <= n; i++)
                {
                    product *= i;
                }

                if (sum > 535 || product > 535)
                {
                    state.Stop(); 
                    Console.WriteLine($"Для числа {n} вычисления прерваны: сумма = {sum}, произведение = {product}");
                }
                else
                {
                    Console.WriteLine($"Для числа {n}: сумма = {sum}, произведение = {product}");
                }
            });
        }
    }
}