using System;
namespace Task4
{
    class Program
    {
        public delegate int RandomDelegate();

        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];

            Random rand = new Random();
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = delegate { return rand.Next(1, 100); };
            }

            Func<RandomDelegate[], double> average = delegate (RandomDelegate[] dels)
            {
                double sum = 0;
                foreach (var del in dels)
                {
                    sum += del();
                }
                return sum / dels.Length;
            };

            double avgResult = average(delegates);
            Console.WriteLine($"Среднее арифметическое: {avgResult}");

            Console.ReadLine();
        }
    }
}