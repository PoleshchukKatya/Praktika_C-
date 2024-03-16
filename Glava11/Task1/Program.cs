using System;

class Car
{
    protected string name;

    public Car(string name)
    {
        this.name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Машина: {name}");
    }

    public virtual double CalculateFuelConsumption()
    {
        return 0;
    }
}

class Truck : Car
{
    protected double carryingCapacity; 

    public Truck(string name, double carryingCapacity) : base(name)
    {
        this.carryingCapacity = carryingCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Грузоподъемность: {carryingCapacity} тон");
    }

    public override double CalculateFuelConsumption()
    {
        return Math.Sqrt(carryingCapacity) * 100;
    }
}

class PassengerCar : Car
{
    protected double engineVolume; 

    public PassengerCar(string name, double engineVolume) : base(name)
    {
        this.engineVolume = engineVolume;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Объем Двигателя: {engineVolume} cm^3");
    }

    public override double CalculateFuelConsumption()
    {
        return 2.5 * engineVolume;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[]
        {
            new Truck("Volvo", 10),
            new PassengerCar("Toyota", 2000),
            new Truck("Scania", 15),
            new PassengerCar("Honda", 1800),
            new Truck("MAN", 12)
        };

        Console.WriteLine("Информация об автомобилях:");
        foreach (Car car in cars)
        {
            car.DisplayInfo();
            Console.WriteLine($"Расход горючего: {car.CalculateFuelConsumption()} литров на 100 км");
            Console.WriteLine();
        }
    }
}