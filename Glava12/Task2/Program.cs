using System;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN; 
                }
                return x / y;
            };

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.Write("Введите номер операции: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Результат: {Add(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Результат: {Sub(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Результат: {Mul(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Результат: {Div(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Ошибка: некорректный выбор операции!");
                    break;
            }

            Console.ReadLine();
        }
    }
}