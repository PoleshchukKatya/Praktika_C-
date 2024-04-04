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

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void buttonRun_Click_1(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string input = string.Empty;
            if (string.IsNullOrEmpty(textBoxEnterName1.Text) || string.IsNullOrWhiteSpace(textBoxEnterName1.Text))
            {
                input = "World!";
            }
            else
            {
                input = textBoxEnterName1.Text;
            }

            TextBlock textBlockHello = (TextBlock)textBoxEnterName.FindName("textBlockHello");
            if (textBlockHello != null)
            {
                textBlockHello.Text = $"{hello} {input}";
            }

        }
        private void buttonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}"; 
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}