using System;
using System.Collections.Generic;
using System.Linq;
namespace Task3_5
{
    /// <summary>
    /// Класс представляющий запись в записной книжке.
    /// </summary>
    public class Record
    {
        private string lastName;
        private string firstName;
        private DateTime birthDate;
        private string phoneNumber;

        /// <summary>
        /// Конструктор для создания новой записи.
        /// </summary>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="firstName">Имя.</param>
        /// <param name="birthDate">Дата рождения.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Record(string lastName, string firstName, DateTime birthDate, string phoneNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
        }

        /// <summary>
        /// Свойство для доступа к фамилии записи.
        /// </summary>
        public string LastName { get { return lastName; } }

        /// <summary>
        /// Свойство для доступа к имени записи.
        /// </summary>
        public string FirstName { get { return firstName; } }

        /// <summary>
        /// Свойство для доступа к дате рождения записи.
        /// </summary>
        public DateTime BirthDate { get { return birthDate; } }

        /// <summary>
        /// Свойство для доступа к номеру телефона записи.
        /// </summary>
        public string PhoneNumber { get { return phoneNumber; } }

        /// <summary>
        /// Переопределение метода ToString для удобного вывода записи.
        /// </summary>
        /// <returns>Строка, содержащая информацию о записи.</returns>
        public override string ToString()
        {
            return $"{lastName} {firstName}, Дата рождения: {birthDate.ToShortDateString()}, Телефон: {phoneNumber}";
        }
    }

    /// <summary>
    /// Класс, представляющий записную книжку.
    /// </summary>
    public class Notebook
    {
        private List<Record> records = new List<Record>();

        /// <summary>
        /// Метод для добавления записи в записную книжку.
        /// </summary>
        /// <param name="record">Запись для добавления.</param>
        public void AddRecord(Record record)
        {
            records.Add(record);
        }

        /// <summary>
        /// Метод для удаления записи из записной книжки по фамилии.
        /// </summary>
        /// <param name="lastName">Фамилия записи для удаления.</param>
        public void RemoveRecord(string lastName)
        {
            records.RemoveAll(r => r.LastName.Equals(lastName));
        }

        /// <summary>
        /// Метод для поиска записи в записной книжке по фамилии.
        /// </summary>
        /// <param name="lastName">Фамилия записи для поиска.</param>
        /// <returns>Найденная запись или null, если запись не найдена.</returns>
        public Record FindRecord(string lastName)
        {
            return records.FirstOrDefault(r => r.LastName.Equals(lastName));
        }

        /// <summary>
        /// Метод для сортировки записей по фамилии.
        /// </summary>
        public void SortByLastName()
        {
            records = records.OrderBy(r => r.LastName).ToList();
        }

        /// <summary>
        /// Метод для получения записи по индексу.
        /// </summary>
        /// <param name="index">Индекс записи.</param>
        /// <returns>Запись по указанному индексу или null, если индекс выходит за пределы.</returns>
        public Record GetRecord(int index)
        {
            if (index >= 0 && index < records.Count)
                return records[index];
            else
                return null;
        }

        /// <summary>
        /// Метод для отображения всех записей в консоли.
        /// </summary>
        public void DisplayAllRecords()
        {
            foreach (var record in records)
            {
                Console.WriteLine(record);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            notebook.AddRecord(new Record("Котик", "Петр", new DateTime(2000, 5, 15), "+375256451239"));
            notebook.AddRecord(new Record("Собачка", "Иван", new DateTime(1995, 10, 20), "+375294568219"));
            Console.WriteLine("Все записи в записной книжке:");
            notebook.DisplayAllRecords();
            Console.WriteLine();

            string searchLastName = "Собачка";
            Record foundRecord = notebook.FindRecord(searchLastName);
            if (foundRecord != null)
                Console.WriteLine($"Найдена запись по фамилии {searchLastName}: {foundRecord}");
            else
                Console.WriteLine($"Запись по фамилии {searchLastName} не найдена.");
            Console.WriteLine();

            notebook.RemoveRecord("Собачка");

            Console.WriteLine("Все записи после удаления:");
            notebook.DisplayAllRecords();
        }
    }
}