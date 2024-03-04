using System;
namespace Task3_3_1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Трехзначные автоморфные числа:");

        for (int i = 100; i < 1000; i++)
        {
            int square = i * i;
            string squareStr = square.ToString();
            string numberStr = i.ToString();

            if (squareStr.EndsWith(numberStr))
            {
                Console.WriteLine(i);
            }
        }
    }
}