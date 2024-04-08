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

namespace Task1._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int squareSize = 50; 
            int boardSize = 8; 
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Rectangle square = new Rectangle();
                    square.Width = squareSize;
                    square.Height = squareSize;

                    if ((row + col) % 2 == 0)
                    {
                        square.Fill = Brushes.White;
                    }
                    else
                    {
                        square.Fill = Brushes.Black;
                    }

                    Canvas.SetLeft(square, col * squareSize);
                    Canvas.SetTop(square, row * squareSize);

                    chessboardCanvas.Children.Add(square);

                    Rectangle borderRectangle = new Rectangle();
                    borderRectangle.Width = boardSize * squareSize;
                    borderRectangle.Height = boardSize * squareSize;
                    borderRectangle.Stroke = Brushes.Black; 
                    borderRectangle.StrokeThickness = 2;
                    borderRectangle.Fill = Brushes.Transparent;

                    Canvas.SetLeft(borderRectangle, 0);
                    Canvas.SetTop(borderRectangle, 0);

                    chessboardCanvas.Children.Add(borderRectangle);
                }
            }
        }
    }
}