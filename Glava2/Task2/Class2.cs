using System;

public class HR : Worker
{
    public string Position { get; set; }

    public void Hire()
    {
        Console.WriteLine($"{Name} нанят на должность {Position}.");
    }
}
