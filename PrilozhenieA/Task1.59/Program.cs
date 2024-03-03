using System;
namespace Task10;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число а:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b:");
        int b = Convert.ToInt32(Console.ReadLine());

        int temp = a; 
        a = b;       
        b = temp;    

        Console.WriteLine($"После обмена: a = {a}, b = {b}");
        Console.ReadLine(); 
    }
}