using System;
namespace Task1
{
    struct STUDENT
    {
        public string fullName;
        public int groupNumber;
        public int[] grades;

        public STUDENT(string name, int group, int[] marks)
        {
            fullName = name;
            groupNumber = group;
            grades = marks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            STUDENT[] students = new STUDENT[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Введите фамилию и инициалы студента {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Введите номер группы для студента {name}:");
                int group = int.Parse(Console.ReadLine());

                Console.WriteLine($"Введите оценки (через пробел) для студента {name}:");
                int[] marks = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                students[i] = new STUDENT(name, group, marks);
            }

            Array.Sort(students, (x, y) => x.fullName.CompareTo(y.fullName));

            bool found = false;
            foreach (var student in students)
            {
                if (Array.Exists(student.grades, grade => grade == 2))
                {
                    Console.WriteLine($"Студент, имеющий хотя бы одну двойку: {student.fullName}, Группа: {student.groupNumber}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Студентов с оценкой 2 не найдено.");
            }
        }
    }
}