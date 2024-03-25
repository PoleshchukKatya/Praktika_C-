using System;
using System.Collections.Generic;
using System.Linq;
namespace WpfLibrary2
{
    public class Store
    {
        private List<Product> products;

        public Store()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(string name)
        {
            var productToRemove = products.FirstOrDefault(p => p.Name == name);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
            }
            else
            {
                Console.WriteLine($"Товар {name} не найден в магазине.");
            }
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Товары в магазине:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
