using System;
namespace Task4_1;
class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Таблица соответствия между весом в фунтах и весом в килограммах:");

            int pounds = 1;
            while (pounds <= 100)
            {
                double kilograms = pounds * 0.453; 
                Console.WriteLine($"{pounds} фунтов = {kilograms} кг");
                pounds++;
            }

            Console.ReadLine(); 
        }
    }
}