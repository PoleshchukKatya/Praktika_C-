using System;
namespace Task11;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число а:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число c:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Схема а):");
        Console.WriteLine($"До обмена: a = {a}, b = {b}, c = {c}");
        int temp = b; 
        b = c;
        c = a;
        a = temp;
        Console.WriteLine($"После обмена: a = {a}, b = {b}, c = {c}");

        Console.WriteLine("\nСхема б):");
        Console.WriteLine($"До обмена: a = {a}, b = {b}, c = {c}");
        temp = b; 
        b = a;
        a = c;
        c = temp;
        Console.WriteLine($"После обмена: a = {a}, b = {b}, c = {c}");
        Console.ReadLine(); 
    }
}
