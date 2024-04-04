using System.Collections.ObjectModel;
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

namespace Task3
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<DataPoint> DataPoints { get; } = new ObservableCollection<DataPoint>();
        public MainWindow()
        {
            InitializeComponent();
            dataListView.ItemsSource = DataPoints;
        }
        private void PlotGraph_Click(object sender, RoutedEventArgs e)
        {
            DataPoints.Clear();
            double step;
            if (!double.TryParse(stepTextBox.Text, out step))
            {
                MessageBox.Show("Некорректное значение шага.");
                return;
            }

            for (double x = 0; x <= 2 * Math.PI; x += step)
            {
                double y = Math.Cos(x);
                DataPoints.Add(new DataPoint { X = x, Y = y });
            }
        }
    }
    public class DataPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}