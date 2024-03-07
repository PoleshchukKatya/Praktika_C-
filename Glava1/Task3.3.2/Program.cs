using System;
namespace Task3_3_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Двузначные числа, сумма квадратов цифр которых кратна 13:");

        for (int i = 10; i < 100; i++)
        {
            int digit1 = i / 10;
            int digit2 = i % 10;
            int sumOfSquares = digit1 * digit1 + digit2 * digit2;

            if (sumOfSquares % 13 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
 