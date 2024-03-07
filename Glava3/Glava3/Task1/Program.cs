﻿using System;
namespace Task1
{
    class Program
    {
        static double Max(double x, double y)
        {
            return x > y ? x : y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            double y = double.Parse(Console.ReadLine());

            double z = Max(x, 2 * y - x) + Max(5 * x + 3 * y, y);

            Console.WriteLine($"Значение выражения z = {z}");
        }
    }
}