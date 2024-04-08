using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawShapes();
        }
        private void DrawShapes()
        {
            Canvas canvas = new Canvas();
            canvas.Width = 500;
            canvas.Height = 500;

            this.Content = canvas;

            Polygon triangle = new Polygon();
            triangle.Points = new PointCollection() { new Point(100, 50), new Point(150, 150), new Point(50, 150) };
            triangle.Stroke = Brushes.Black;
            canvas.Children.Add(triangle);

            Ellipse ellipse = new Ellipse();
            ellipse.Width = 100;
            ellipse.Height = 50;
            ellipse.Stroke = Brushes.Black;
            Canvas.SetLeft(ellipse, 200);
            Canvas.SetTop(ellipse, 50);
            canvas.Children.Add(ellipse);

            Ellipse filledCircle = new Ellipse();
            filledCircle.Width = 100;
            filledCircle.Height = 100;
            filledCircle.Fill = Brushes.LightCoral;
            filledCircle.Stroke = Brushes.Black;
            Canvas.SetLeft(filledCircle, 350);
            Canvas.SetTop(filledCircle, 50);
            canvas.Children.Add(filledCircle);

            Rectangle filledRectangle = new Rectangle();
            filledRectangle.Width = 100;
            filledRectangle.Height = 50;
            filledRectangle.Fill = Brushes.LightYellow;
            filledRectangle.Stroke = Brushes.Black;
            Canvas.SetLeft(filledRectangle, 100);
            Canvas.SetTop(filledRectangle, 200);
            canvas.Children.Add(filledRectangle);

            PathGeometry sectorGeometry = new PathGeometry();
            PathFigure sectorFigure = new PathFigure();
            sectorFigure.StartPoint = new Point(300, 200);
            sectorFigure.Segments.Add(new LineSegment(new Point(400, 200), true));
            sectorFigure.Segments.Add(new ArcSegment(new Point(350, 250), new Size(50, 50), 0, false, SweepDirection.Clockwise, true));
            sectorFigure.IsClosed = true;
            sectorGeometry.Figures.Add(sectorFigure);
            Path sectorPath = new Path();
            sectorPath.Stroke = Brushes.Black;
            sectorPath.Data = sectorGeometry;
            canvas.Children.Add(sectorPath);
        }
    }
}
