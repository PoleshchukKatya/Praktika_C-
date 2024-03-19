using System;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mi = new MyInfo("Полещук Катя");

            mi.Notify += (string notify) => { Console.WriteLine(notify); };

            mi.Name = "Полещук Екатерина";

            Console.ReadKey();
        }
    }
    public class MyInfo
    {
        public event Action<string> Notify;

        private string _name;

        public MyInfo(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!_name.Equals(value))
                {
                    Notify?.Invoke($"Значение поля {nameof(Name)} изменено. Предыдущее значение = {_name}, актуальное = {value}.");
                }
                _name = value;
            }
        }
    }
}