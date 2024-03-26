using System;
using System.Collections.Generic;
using System.IO;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";

            CreateFile(filePath);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            Queue<char> nonDigitsQueue = new Queue<char>();
            Queue<char> digitsQueue = new Queue<char>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    char c = (char)reader.Read();
                    if (char.IsDigit(c))
                    {
                        digitsQueue.Enqueue(c);
                    }
                    else
                    {
                        nonDigitsQueue.Enqueue(c);
                    }
                }
            }
            Console.WriteLine("Элементы файла в порядке: сначала символы, затем цифры:");
            while (nonDigitsQueue.Count > 0)
            {
                Console.Write(nonDigitsQueue.Dequeue());
            }
            while (digitsQueue.Count > 0)
            {
                Console.Write(digitsQueue.Dequeue());
            }
            Console.WriteLine();
        }
        static void CreateFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, world!");
                    writer.WriteLine("12345");
                    writer.WriteLine("Test file creation.");
                }
                Console.WriteLine($"Файл успешно создан: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
            }
        }
    }
}