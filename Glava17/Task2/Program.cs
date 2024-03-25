using System;
using MyStoreLibrary;

class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();

        store.AddProduct(new Product("Молоко", 2.5));
        store.AddProduct(new Product("Хлеб", 1.0));
        store.AddProduct(new Product("Яблоки", 3.0));

        store.DisplayProducts();

        store.RemoveProduct("Хлеб");

        store.DisplayProducts();

        Console.ReadLine();
    }
}