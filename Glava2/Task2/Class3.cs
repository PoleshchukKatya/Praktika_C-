using System;


public class Engineer : Worker
{
    public string Specialization { get; set; }

    public void Develop()
    {
        Console.WriteLine($"{Name} разрабатывает новый продукт.");
    }
}
