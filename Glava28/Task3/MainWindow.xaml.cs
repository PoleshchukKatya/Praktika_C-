﻿using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }
        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Triangle Button Clicked!");
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Circle Button Clicked!");
        }

    }
}