using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Extensions.Logging;

namespace WpfApp1
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);

        void Add(Student student);

        void Delete(string surname);

        Student FindBy(string surname);

        List<Student> GetAll();
    }

    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {Name}, BirthDate: {BirthDate.ToShortDateString()}";
        }
    }

    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Student student)
        {
            var xRoot = _document.DocumentElement;

            XmlElement studentElement = _document.CreateElement("студент");
            studentElement.SetAttribute("фамилия", student.Surname);
            studentElement.SetAttribute("имя", student.Name);
            studentElement.SetAttribute("дата_рождения", student.BirthDate.ToString("yyyy-MM-dd"));

            xRoot.AppendChild(studentElement);
            _document.Save(_xmlFilePath);
        }

        public void Delete(string surname)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    var attributeSurname = xnode.Attributes.GetNamedItem("фамилия");
                    try
                    {
                        var attributeSurnameText = attributeSurname?.InnerText;
                        if (attributeSurnameText.Equals(surname))
                        {
                            xRoot.RemoveChild(xnode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeSurname));
                    }
                }
            }
        }

        public Student FindBy(string surname)
        {
            Student student = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xmlNode in xRoot)
            {
                student = GetStudent(xmlNode);
                if (student.Surname.Equals(surname))
                {
                    return student;
                }
            }
            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                var student = GetStudent(xnode);
                students.Add(student);
            }
            return students;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }

        public Student GetStudent(XmlNode node)
        {
            var student = new Student();
            if (node.Attributes.Count > 0)
            {
                var attributeSurname = node.Attributes.GetNamedItem("фамилия");
                var attributeName = node.Attributes.GetNamedItem("имя");
                var attributeBirthDate = node.Attributes.GetNamedItem("дата_рождения");

                student.Surname = attributeSurname?.Value;
                student.Name = attributeName?.Value;
                student.BirthDate = DateTime.ParseExact(attributeBirthDate?.Value, "yyyy-MM-dd", null);
            }
            return student;
        }
    }
}
