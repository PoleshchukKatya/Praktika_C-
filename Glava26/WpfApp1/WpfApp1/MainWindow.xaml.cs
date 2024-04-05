using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using WpfApp1.models;
using Microsoft.Extensions.Logging;
using WpfApp1.Share;
using System.Windows.Controls.Primitives;

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
            foreach (var student in students)
            {
                textBlockXmlFileContent.Text += student.ToString() + Environment.NewLine;
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";

            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintStudents(_worker.GetAll());
                CheckButtonsAvailability();
            }
        }

        private void buttonFindStudentSurname_Click(object sender, RoutedEventArgs e)
        {
            var student = _worker.FindBy(textBoxStudentSurname.Text);
            textBlockXmlFileContent.Text = student != null ? student.ToString() : "Student not found";
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
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteSurname.Text))
            {
                _worker.Delete(textBoxDeleteSurname.Text);
                PrintStudents(_worker.GetAll());
            }
        }

        private void CheckButtonsAvailability()
        {
            bool isXmlFileSelected = !string.IsNullOrEmpty(_xmlFilePath);
            buttonFindStudentSurname.IsEnabled = isXmlFileSelected;
            buttonAdd.IsEnabled = isXmlFileSelected;
            buttonDelete.IsEnabled = isXmlFileSelected;
        }

        private void buttonExit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
