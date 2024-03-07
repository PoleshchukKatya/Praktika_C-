using System;
namespace Task3_3_9;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Двузначные числа, равные утроенному произведению своих цифр:");

        for (int i = 10; i < 100; i++)
        {
            int digit1 = i / 10; 
            int digit2 = i % 10;

            int product = digit1 * digit2 * 3; 

            if (product == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}