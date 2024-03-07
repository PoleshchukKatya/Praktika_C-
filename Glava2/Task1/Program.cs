using System;
class A
{
    private int a;
    private int b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int Multiply()
    {
        return a * b;
    }

    public double CalculateExpression()
    {
        return Math.Sqrt(b) / (2 * a);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Значение поля 'a': {a}");
        Console.WriteLine($"Значение поля 'b': {b}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            A objA = new A(5, 10);

            objA.DisplayInfo();
            Console.WriteLine($"Произведение a и b: {objA.Multiply()}");
            Console.WriteLine($"Значение выражения √b / (2 * a): {objA.CalculateExpression()}");
        }
    }
}