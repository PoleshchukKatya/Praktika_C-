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

namespace Task1._2
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

            double[] radii = { 100, 50, 25 };

            Point center = new Point(canvas.Width / 2, canvas.Height / 2);

            Ellipse outerCircle = new Ellipse();
            outerCircle.Width = radii[0] * 2;
            outerCircle.Height = radii[0] * 2;
            outerCircle.Stroke = Brushes.Black;
            outerCircle.StrokeThickness = 2;
            double outerCircleLeft = center.X - radii[0];
            double outerCircleTop = center.Y - radii[0];
            Canvas.SetLeft(outerCircle, outerCircleLeft);
            Canvas.SetTop(outerCircle, outerCircleTop);
            canvas.Children.Add(outerCircle);

            for (int i = 1; i < radii.Length; i++)
            {
                double radius = radii[i];
                Ellipse circle = new Ellipse();
                circle.Width = radius * 2;
                circle.Height = radius * 2;
                circle.Stroke = Brushes.Black;
                circle.StrokeThickness = 2;

                double circleLeft = center.X - radius;
                double circleTop = center.Y - radius;

                Canvas.SetLeft(circle, circleLeft);
                Canvas.SetTop(circle, circleTop);
                canvas.Children.Add(circle);

                center.X = circleLeft + radius;
                center.Y = circleTop + radius;
            }
        }
    }
}