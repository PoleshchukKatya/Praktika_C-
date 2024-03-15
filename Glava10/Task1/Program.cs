using System;

class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public double GetPrice()
    {
        return price;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: ${price}");
    }
}

class PaperbackBook : Book
{
    private string coverMaterial;

    public PaperbackBook(string title, string author, double price, string coverMaterial) : base(title, author, price)
    {
        this.coverMaterial = coverMaterial;
    }

    public new void Display()
    {
        base.Display(); 
        Console.WriteLine($"Cover Material: {coverMaterial}");
    }

    public new double GetPrice()
    {
        return base.GetPrice() + 50;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Harry Potter", "J.K. Rowling", 20.5);

        Console.WriteLine("Testing Base Class Methods:");
        Console.WriteLine($"Title: {book1.GetTitle()}");
        Console.WriteLine($"Author: {book1.GetAuthor()}");
        Console.WriteLine($"Price: ${book1.GetPrice()}");
        Console.WriteLine();

        PaperbackBook paperbackBook1 = new PaperbackBook("The Great Gatsby", "F. Scott Fitzgerald", 15.75, "Paperback");

        Console.WriteLine("Testing Derived Class Methods:");
        paperbackBook1.Display();
        Console.WriteLine($"Adjusted Price (with cover): ${paperbackBook1.GetPrice()}");
    }
}