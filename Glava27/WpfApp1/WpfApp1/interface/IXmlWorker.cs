using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.models;

namespace WpfApp1
{
    public interface IXmlWorker
    {
        void Load(string filePath);
        List<Student> GetAll();
        Student FindBy(string surname);
        void Add(Student student);
        void Delete(string surname);
    }

}



