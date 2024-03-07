using System;
using System.Collections.Generic;
using System.Linq;

public class Record
{
    private string lastName;
    private string firstName;
    private DateTime birthDate;
    private string phoneNumber;

    public Record(string lastName, string firstName, DateTime birthDate, string phoneNumber)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.birthDate = birthDate;
        this.phoneNumber = phoneNumber;
    }

    public string LastName { get { return lastName; } }
    public string FirstName { get { return firstName; } }
    public DateTime BirthDate { get { return birthDate; } }
    public string PhoneNumber { get { return phoneNumber; } }

    public override string ToString()
    {
        return $"{lastName} {firstName}, Дата рождения: {birthDate.ToShortDateString()}, Телефон: {phoneNumber}";
    }
}

public class Notebook
{
    private List<Record> records = new List<Record>();

    public void AddRecord(Record record)
    {
        records.Add(record);
    }

    public void RemoveRecord(string lastName)
    {
        records.RemoveAll(r => r.LastName.Equals(lastName));
    }

    public Record FindRecord(string lastName)
    {
        return records.FirstOrDefault(r => r.LastName.Equals(lastName));
    }

    public void SortByLastName()
    {
        records = records.OrderBy(r => r.LastName).ToList();
    }

    public Record GetRecord(int index)
    {
        if (index >= 0 && index < records.Count)
            return records[index];
        else
            return null;
    }

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