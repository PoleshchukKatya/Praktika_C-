using System;
using System.IO;
namespace Task16_2
{
    /// <summary>
    /// Класс для создания папки.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Основной метод программы.
        /// </summary>
        static void Main()
        {
            string folderName = "New_folder";

            // Получение пути к папке
            string folderPath = Path.Combine(Environment.CurrentDirectory, folderName);

            // Проверка на существование папки и создание, если не существует
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