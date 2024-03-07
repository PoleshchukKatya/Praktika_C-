using System;
namespace Task4_3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблица соответствия между весом в фунтах и весом в килограммах:");

        int pounds = 1;
        do
        {
            double kilograms = pounds * 0.453; 
            Console.WriteLine($"{pounds} фунтов = {kilograms} кг");
            pounds++;
        } while (pounds <= 100);

        Console.ReadLine(); 
    }
}