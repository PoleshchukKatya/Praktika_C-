using System;
namespace ShapesLibrary
{
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

        public bool IsExist()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string DetermineType()
        {
            if (SideA == SideB && SideB == SideC)
                return "равносторонний";
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
                return "равнобедренный";
            else
                return "разносторонний";
        }
    }
}

