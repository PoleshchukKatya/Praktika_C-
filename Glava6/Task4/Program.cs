using System;
namespace Task4
{
    class Program
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static int CalculateIdentityCode(string fullName)
        {
            int sum = 0;
            foreach (char letter in fullName.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    sum += letter - 'a' + 1;
                }
            }
            while (sum >= 10)
            {
                sum = SumOfDigits(sum);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию, имя и отчество через пробел:");
            string fullName = Console.ReadLine();

            int identityCode = CalculateIdentityCode(fullName);
            Console.WriteLine($"Код личности для {fullName}: {identityCode}");

            Console.ReadLine();
        }
    }
}