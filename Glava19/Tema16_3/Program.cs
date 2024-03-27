using System;
using System.IO;
using System.Linq;
namespace Task16_3
{
    /// <summary>
    /// Класс для работы с файлом текста.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Основной метод программы.
        /// </summary>
        static void Main()
        {
            string filePath = "text.txt";

            string[] lines = {
            "Привет, мир!",
            "Как дела?",
            "Сегодня хорошая погода.",
            "Что нового?",
            "Давай встретимся завтра."
            };

            // Запись строк в файл
            File.WriteAllLines(filePath, lines);

            // Вывод содержимого файла
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine();

            // Получение количества строк в файле
            int lineCount = File.ReadLines(filePath).Count();
            Console.WriteLine($"Количество строк в файле: {lineCount}");

            // Вывод количества символов в каждой строке
            Console.WriteLine("Количество символов в каждой строке:");
            foreach (string line in lines)
            {
                Console.WriteLine($"{line}: {line.Length} симв.");
            }
            Console.WriteLine();

            // Удаление последней строки из файла
            string[] remainingLines = lines.Take(lines.Length - 1).ToArray();
            string newFilePath = "new_text.txt";
            File.WriteAllLines(newFilePath, remainingLines);
            Console.WriteLine($"Последняя строка удалена из файла. Результат записан в файл {newFilePath}");
            Console.WriteLine();

            // Вывод строк с s1 по s2
            int s1 = 1;
            int s2 = 3;
            Console.WriteLine($"Строки с {s1} по {s2}:");
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }
            Console.WriteLine();

            // Вывод длины самой длинной строки
            int maxLength = lines.Max(s => s.Length);
            Console.WriteLine($"Длина самой длинной строки: {maxLength} симв.");

            // Вывод строк, начинающихся с буквы targetLetter
            char targetLetter = 'С';
            Console.WriteLine($"Строки, начинающиеся с буквы '{targetLetter}':");
            foreach (string line in lines)
            {
                if (line.StartsWith(targetLetter.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine();

            // Переворот строк в файле
            Array.Reverse(lines);
            string reversedFilePath = "reversed_text.txt";
            File.WriteAllLines(reversedFilePath, lines);
            Console.WriteLine($"Строки файла переписаны в файл {reversedFilePath} в обратном порядке.");
        }
    }
}