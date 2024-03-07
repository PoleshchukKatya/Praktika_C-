using System;

namespace Task1
{
    internal class A
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
    }
}
