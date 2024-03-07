using System;

public class Administration : Worker
{
    public string Position { get; set; }
    public void Manage()
    {
        Console.WriteLine($"{Name} управляет отделом.");
    }
}
