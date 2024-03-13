using System;
namespace Task2
{
    enum Position
    {
        Manager = 160,   
        Developer = 180,    
        QA = 150           
    }

    struct STUDENT
    {
        public string fullName;
        public int groupNumber;
        public int[] performance;

        public STUDENT(string name, int group, int[] marks)
        {
            fullName = name;
            groupNumber = group;
            performance = marks;
        }
    }

    class Accountant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            int requiredHours = (int)worker;

            if (hours > requiredHours)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Position position1 = Position.Manager;
            Position position2 = Position.Developer;
            Position position3 = Position.QA;

            Accountant accountant = new Accountant();

            Console.WriteLine("Менеджер получит премию: " + accountant.AskForBonus(Position.Manager, 170)); 
            Console.WriteLine("Разработчик получит премию: " + accountant.AskForBonus(Position.Developer, 160)); 
            Console.WriteLine("Тестировщик получит премию: " + accountant.AskForBonus(Position.QA, 160)); 
        }
    }
}