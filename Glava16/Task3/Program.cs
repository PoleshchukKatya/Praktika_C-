using System;
using System.IO;
using System.Linq;
namespace Task3
{
    class Program
    {
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
            File.WriteAllLines(filePath, lines);

            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine();

            int lineCount = File.ReadLines(filePath).Count();
            Console.WriteLine($"Количество строк в файле: {lineCount}");

            Console.WriteLine("Количество символов в каждой строке:");
            foreach (string line in lines)
            {
                Console.WriteLine($"{line}: {line.Length} симв.");
            }
            Console.WriteLine();

            string[] remainingLines = lines.Take(lines.Length - 1).ToArray();
            string newFilePath = "new_text.txt";
            File.WriteAllLines(newFilePath, remainingLines);
            Console.WriteLine($"Последняя строка удалена из файла. Результат записан в файл {newFilePath}");
            Console.WriteLine();

            int s1 = 1;
            int s2 = 3;
            Console.WriteLine($"Строки с {s1} по {s2}:");
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }
            Console.WriteLine();

            int maxLength = lines.Max(s => s.Length);
            Console.WriteLine($"Длина самой длинной строки: {maxLength} симв.");

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

            Array.Reverse(lines);
            string reversedFilePath = "reversed_text.txt";
            File.WriteAllLines(reversedFilePath, lines);
            Console.WriteLine($"Строки файла переписаны в файл {reversedFilePath} в обратном порядке.");
        }
    }
}