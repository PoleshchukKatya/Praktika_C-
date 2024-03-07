using System;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR { Name = "Иван", Position = "HR Specialist" };
            hr.Hire();

            Engineer engineer = new Engineer { Name = "Петр", Specialization = "Software Engineer" };
            engineer.Develop();

            Administration admin = new Administration { Name = "Мария", Position = "Manager" };
            admin.Manage();

            Console.ReadLine();
        }
    }
}