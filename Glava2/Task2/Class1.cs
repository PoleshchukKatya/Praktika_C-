using System;

public class Worker
{
    public string Name { get; set; }
    public void Work()
    {
        Console.WriteLine($"{Name} работает.");
    }
}
