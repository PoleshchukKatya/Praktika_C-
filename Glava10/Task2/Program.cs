using System;

class A
{
    protected int a = 5;
    protected int b = 7;

    public int c
    {
        get { return a * b; }
    }

    public A() { }
}

class B : A
{

    private int d = 10;

    public int c2
    {
        get
        {
            int result = 0;
            for (int i = 0; i < d; i++)
            {
                result += a + b;
            }
            return result;
        }
    }

    public B() : base() { }

    public B(int a, int b, int d)
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }
}

class Program
{
    static void Main(string[] args)
    {
        A aObject = new A();
        Console.WriteLine($"Значение свойства c для объекта класса A: {aObject.c}");

        B bObject1 = new B();
        Console.WriteLine($"Значение свойства c для объекта класса B (конструктор наследуется от класса A): {bObject1.c}");

        B bObject2 = new B(2, 3, 4);
        Console.WriteLine($"Значение свойства c2 для объекта класса B (собственный конструктор): {bObject2.c2}");
    }
}