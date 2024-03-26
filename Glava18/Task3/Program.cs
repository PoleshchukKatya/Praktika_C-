using System;
using System.Collections.Generic;
namespace Task3
{
    class MenuItem
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        { 
            return $"{Name} - {Price} руб.";
        }
    }
    class Menu
    {
        private List<MenuItem> items = new List<MenuItem>();
        public void AddItem(string name, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, price);
            items.Add(menuItem);
        }
        public bool RemoveItem(string name)
        {
            MenuItem menuItem = items.Find(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (menuItem != null)
            {
                items.Remove(menuItem);
                return true;
            }
            return false;
        }
        public Menu Clone()
        {
            Menu cloneMenu = new Menu();
            foreach (var item in items)
            {
                cloneMenu.AddItem(item.Name, item.Price);
            }
            return cloneMenu;
        }
        public void DisplayItems()
        {
            foreach (var menuItem in items)
            {
                Console.WriteLine(menuItem);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu cafeMenu = new Menu();

            cafeMenu.AddItem("Шаурма", 15);
            cafeMenu.AddItem("Бургер", 6);
            cafeMenu.AddItem("Кофе", 7);
            cafeMenu.AddItem("Пицца", 30);

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить блюдо в меню");
                Console.WriteLine("2. Удалить блюдо из меню");
                Console.WriteLine("3. Клонировать меню");
                Console.WriteLine("4. Вывести блюда в меню");
                Console.WriteLine("5. Выход");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Введите название блюда: ");
                        string nameToAdd = Console.ReadLine();
                        Console.Write("Введите цену блюда: ");
                        decimal priceToAdd;
                        while (!decimal.TryParse(Console.ReadLine(), out priceToAdd))
                        {
                            Console.WriteLine("Некорректный ввод. Пожалуйста, введите цену числом.");
                        }
                        cafeMenu.AddItem(nameToAdd, priceToAdd);
                        break;
                    case "2":
                        Console.Write("Введите название блюда для удаления: ");
                        string nameToRemove = Console.ReadLine();
                        if (cafeMenu.RemoveItem(nameToRemove))
                        {
                            Console.WriteLine("Блюдо успешно удалено из меню.");
                        }
                        else
                        {
                            Console.WriteLine("Блюдо не найдено в меню.");
                        }
                        break;
                    case "3":
                        Menu clonedMenu = cafeMenu.Clone();
                        Console.WriteLine("Клонированное меню кафе:");
                        clonedMenu.DisplayItems();
                        break;
                    case "4":
                        Console.WriteLine("Блюда в меню кафе:");
                        cafeMenu.DisplayItems();
                        break;
                    case "5":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, выберите действие из списка.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}