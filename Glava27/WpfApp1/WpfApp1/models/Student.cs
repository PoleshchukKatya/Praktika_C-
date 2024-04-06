using System;

namespace WpfApp1.models
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {Name}, BirthDate: {BirthDate.ToShortDateString()}";
        }
    }
}
