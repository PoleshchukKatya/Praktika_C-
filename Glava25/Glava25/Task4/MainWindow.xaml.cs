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

namespace Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Button newButton = new Button();
                newButton.Content = "Новая кнопка";
                newButton.Margin = new Thickness(10); 
                newButton.Click += NewButton_Click; 

                if (button.Parent is Panel panel)
                {
                    panel.Children.Add(newButton);
                }
            }
        }
        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Parent is Panel panel)
                {
                    panel.Children.Remove(button);
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}