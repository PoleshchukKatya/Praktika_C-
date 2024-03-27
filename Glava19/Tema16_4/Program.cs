using System;
using System.IO;
namespace Task16_4
{
    /// <summary>
    /// Класс для обмена строк между файлами.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Основной метод программы.
        /// </summary>
        static void Main()
        {
            string file1Path = "file1.txt";
            string file2Path = "file2.txt";

            // Запись строк в файлы
            File.WriteAllLines(file1Path, new string[] { "Первая строка", "Вторая строка", "Третья строка" });
            File.WriteAllLines(file2Path, new string[] { "Fourth line", "Fifth line", "Sixth line" });

            // Чтение строк из файлов
            string[] file1Lines = File.ReadAllLines(file1Path);
            string[] file2Lines = File.ReadAllLines(file2Path);

            // Обмен строк между файлами
            File.WriteAllLines(file1Path, file2Lines);
            File.WriteAllLines(file2Path, file1Lines);

            Console.WriteLine("Строки из файлов были обменены.");
        }
    }
}
