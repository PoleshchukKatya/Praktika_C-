using System;
namespace Task1
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler uniqueInstance;
        private static readonly object lockObject = new object();
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstanceUsingLock()
        {
            lock (lockObject)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new ChocolateBoiler();
                }
                return uniqueInstance;
            }
        }

        public static ChocolateBoiler GetInstanceUsingDoubleCheck()
        {
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }
            return uniqueInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Наполнение котла молочно-шоколадной смесью...");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
                Console.WriteLine("Сливание нагретой молочно-шоколадной смеси...");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
                Console.WriteLine("Нагрев молочно-шоколадной смеси до кипения...");
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstanceUsingDoubleCheck();

            boiler.Fill();
            boiler.Boil();

            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstanceUsingDoubleCheck();

            Console.WriteLine("Являются ли оба экземпляра одним и тем же объектом? " + (boiler == boiler2));

            boiler.Drain();
        }
    }
}