namespace ShapesLibrary
{
    public class Rectangle
    {
        public double Length { get; private set; }
        public double Width { get; private set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
