using System;
namespace Task2
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

    public class DelegateUser
    {
        public void UseDelegate(ColorDelegate del)
        {
            Console.WriteLine(del());
        }

        public void UseDelegateAsParameter(ColorDelegate del)
        {
            foreach (ColorDelegate method in del.GetInvocationList())
            {
                Console.WriteLine(method());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ColorGetter colorGetter = new ColorGetter();
            DelegateUser delegateUser = new DelegateUser();

            ColorDelegate colorDelegate = colorGetter.GetRed;
            colorDelegate += colorGetter.GetGreen;
            colorDelegate += colorGetter.GetBlue;

            delegateUser.UseDelegateAsParameter(colorDelegate);
        }
    }
}