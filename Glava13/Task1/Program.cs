using System;
namespace Task1
{
    public class ColorGetter
    {
        public string GetRed()
        {
            return "Красный";
        }

        public string GetGreen()
        {
            return "Зеленый";
        }

        public string GetBlue()
        {
            return "Голубой";
        }
    }

    public delegate string ColorDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            ColorGetter colorGetter = new ColorGetter();

            ColorDelegate colorDelegate = colorGetter.GetRed;
            colorDelegate += colorGetter.GetGreen;
            colorDelegate += colorGetter.GetBlue;

            foreach (ColorDelegate method in colorDelegate.GetInvocationList())
            {
                Console.WriteLine(method());
            }
        }
    }
}