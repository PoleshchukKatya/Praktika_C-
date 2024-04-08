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

namespace Task1._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double width = 50;
            double height = 80;

            for (int i = 0; i < 5; i++)
            {
                Rectangle rect = new Rectangle();
                rect.Width = width;
                rect.Height = height;
                rect.Stroke = Brushes.Black; 
                Canvas.SetLeft(rect, i * width / 1.5); 
                Canvas.SetTop(rect, i * height / 1.5);
                myCanvas.Children.Add(rect);
            }
        }
    }
}