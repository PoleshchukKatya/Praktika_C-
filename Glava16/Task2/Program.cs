using System;
using System.IO;
namespace Task2
{
    class Program
    {
        static void Main()
        {
            string folderName = "New_folder";

            string folderPath = Path.Combine(Environment.CurrentDirectory, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine($"Папка '{folderName}' успешно создана.");
            }
            else
            {
                Console.WriteLine($"Папка '{folderName}' уже существует.");
            }
        }
    }
}