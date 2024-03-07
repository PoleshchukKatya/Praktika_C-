using System;
namespace Task4_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблица соответствия между весом в фунтах и весом в килограммах:");

        for (int pounds = 1; pounds <= 100; pounds++)
        {
            double kilograms = pounds * 0.453; 
            Console.WriteLine($"{pounds} фунтов = {kilograms} кг");
        }

        Console.ReadLine(); 
    }
}