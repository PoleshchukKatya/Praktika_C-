using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawingCanvas.SizeChanged += DrawingCanvas_SizeChanged;
        }

        private void DrawingCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawShapes();
        }

        private void DrawShapes()
        {
            if (drawingCanvas.ActualWidth == 0 || drawingCanvas.ActualHeight == 0)
            {
                return;
            }

            double[] radii = { 100, 50, 25 };

            double startY = (drawingCanvas.ActualHeight - radii[0] * 2) / 2;

            Point[] trianglePoints = { new Point(100, startY), new Point(150, startY + 100), new Point(50, startY + 100) };
            Polygon triangle = new Polygon();
            triangle.Points = new PointCollection(trianglePoints);
            triangle.Stroke = Brushes.Black;
            triangle.Fill = Brushes.Transparent;
            drawingCanvas.Children.Add(triangle);

            double centerX = 200 + radii[0];
            for (int i = 0; i < radii.Length; i++)
            {
                DrawEllipse(Brushes.LightCoral, Brushes.Black, new Point(centerX, startY + radii[i]), radii[i], radii[i]);
                centerX += radii[i] * 2 + 20; 
            }

            double rectangleTop = startY + radii[0] * 2 + 40;
            Rect rectangleRect = new Rect(new Point(100, rectangleTop), new Point(200, rectangleTop + 100));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = rectangleRect.Width;
            rectangle.Height = rectangleRect.Height;
            rectangle.Stroke = Brushes.Black;
            rectangle.Fill = Brushes.LightYellow;
            Canvas.SetLeft(rectangle, rectangleRect.Left);
            Canvas.SetTop(rectangle, rectangleRect.Top);
            drawingCanvas.Children.Add(rectangle);

            // Рисуем сектор
            double sectorY = startY + radii[0] + 200;
            PathGeometry sectorGeometry = new PathGeometry();
            PathFigure sectorFigure = new PathFigure();
            sectorFigure.StartPoint = new Point(300, sectorY);
            sectorFigure.Segments.Add(new LineSegment(new Point(400, sectorY), true));
            sectorFigure.Segments.Add(new ArcSegment(new Point(350, sectorY + 50), new Size(50, 50), 0, false, SweepDirection.Clockwise, true));
            sectorFigure.IsClosed = true;
            sectorGeometry.Figures.Add(sectorFigure);
            Path sectorPath = new Path();
            sectorPath.Stroke = Brushes.Black;
            sectorPath.Data = sectorGeometry;
            drawingCanvas.Children.Add(sectorPath);
        }

        private void DrawEllipse(Brush fill, Brush stroke, Point center, double width, double height)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = width * 2;
            ellipse.Height = height * 2;
            ellipse.Stroke = stroke;
            ellipse.Fill = fill;
            Canvas.SetLeft(ellipse, center.X - width);
            Canvas.SetTop(ellipse, center.Y - height);
            drawingCanvas.Children.Add(ellipse);
        }
    }
}
