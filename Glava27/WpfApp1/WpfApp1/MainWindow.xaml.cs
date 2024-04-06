using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using WpfApp1.models;
using Microsoft.Extensions.Logging;
using WpfApp1.Share;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private readonly XmlDocumentWorker _worker;
        private string _xmlFilePath;

        public MainWindow()
        {
            InitializeComponent();
            _worker = new XmlDocumentWorker(new LoggerFactory().CreateLogger<XmlDocumentWorker>());
            CheckButtonsAvailability();
        }

        private void PrintStudents(List<Student> students)
        {
            textBlockXmlFileContent.Text = "===Students===" + Environment.NewLine;
            textBoxList.Text = "";

            foreach (var student in students)
            {
                textBlockXmlFileContent.Text += student.ToString() + Environment.NewLine;

                var item = new TreeViewItem() { Header = student.ToString() };
                treeViewList.Items.Add(item);

                listBox.Items.Add(student.ToString());

                textBoxList.Text += student.ToString() + Environment.NewLine;
            }
        }

        private void CheckButtonsAvailability()
        {
            bool isXmlFileSelected = !string.IsNullOrEmpty(_xmlFilePath);
            buttonFindStudentSurname.IsEnabled = isXmlFileSelected;
            buttonAdd.IsEnabled = isXmlFileSelected;
            buttonDelete.IsEnabled = isXmlFileSelected;
        }

        private void buttonOpenFile_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";

            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                LoadFile(dialog.FileName);
            }
        }

        private void buttonFindStudentSurname_Click(object sender, RoutedEventArgs e)
        {
            var student = _worker.FindBy(textBoxStudentSurname.Text);
            textBlockXmlFileContent.Text = student != null ? student.ToString() : "Student not found";
            UpdateData();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteSurname.Text))
            {
                _worker.Delete(textBoxDeleteSurname.Text);
                PrintStudents(_worker.GetAll());
                UpdateData();
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student
            {
                Surname = textBoxSurname.Text,
                Name = textBoxName.Text,
                BirthDate = DateTime.Parse(textBoxBirthDate.Text)
            };

            _worker.Add(student);
            PrintStudents(_worker.GetAll());
            UpdateData();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBoxRadioButton.IsChecked == true)
            {
                textBoxList.Visibility = Visibility.Visible;
                treeViewList.Visibility = Visibility.Collapsed;
                listBox.Visibility = Visibility.Collapsed;
            }
            else if (treeViewRadioButton.IsChecked == true)
            {
                textBoxList.Visibility = Visibility.Collapsed;
                treeViewList.Visibility = Visibility.Visible;
                listBox.Visibility = Visibility.Collapsed;
            }
            else if (listBoxRadioButton.IsChecked == true)
            {
                textBoxList.Visibility = Visibility.Collapsed;
                treeViewList.Visibility = Visibility.Collapsed;
                listBox.Visibility = Visibility.Visible;
            }
            UpdateData();
        }

        private void LoadFile(string filePath)
        {
            _xmlFilePath = filePath;
            textBlockXMLPathFile.Text = _xmlFilePath;
            _worker.Load(_xmlFilePath);
            PrintStudents(_worker.GetAll());
            CheckButtonsAvailability();
        }

        private void UpdateData()
        {
            if (textBoxRadioButton.IsChecked == true)
            {
                textBoxList.Text = textBlockXmlFileContent.Text;
            }
            else if (treeViewRadioButton.IsChecked == true)
            {
                treeViewList.Items.Clear();
                foreach (var student in _worker.GetAll())
                {
                    var item = new TreeViewItem() { Header = student.ToString() };
                    treeViewList.Items.Add(item);
                }
            }
            else if (listBoxRadioButton.IsChecked == true)
            {
                listBox.Items.Clear();
                foreach (var student in _worker.GetAll())
                {
                    listBox.Items.Add(student.ToString());
                }
            }
        }
    }
}
