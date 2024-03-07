using System;

public class Triangle
{
    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public void Move(double deltaX, double deltaY)
    {
        Console.WriteLine($"Треугольник перемещен на ({deltaX}, {deltaY}).");
    }

    public void Resize(double scaleFactor)
    {
        SideA *= scaleFactor;
        SideB *= scaleFactor;
        SideC *= scaleFactor;
        Console.WriteLine($"Треугольник изменен в размерах с коэффициентом масштабирования {scaleFactor}.");
    }

    public void Rotate(double angleDegrees)
    {
        Console.WriteLine($"Треугольник повернут на {angleDegrees} градусов.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Состояние треугольника:");
        Console.WriteLine($"Сторона A: {SideA}");
        Console.WriteLine($"Сторона B: {SideB}");
        Console.WriteLine($"Сторона C: {SideC}");
    }
}
