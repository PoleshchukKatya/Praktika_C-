using System;
namespace Task7;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение угла a : ");
        double a = Convert.ToDouble(Console.ReadLine());

        double z1_num = Math.Sin(4 * a);
        double z1_den = 1 + Math.Cos(4 * a);
        double z1_dividend = Math.Cos(2 * a);
        double z1_divider = 1 + Math.Cos(2 * a);
        double z1 = (z1_num / z1_den) * (z1_dividend / z1_divider);

        double z2_angle = (3.0 / 2.0) * Math.PI - a;
        double z2 = 1 / Math.Tan(z2_angle);

        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
        Console.ReadLine();
    }
}
