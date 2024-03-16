using System;
 
abstract class Car
{
    protected string name;

    public Car(string name)
    {
        this.name = name;
    }

    public abstract void DisplayInfo();

    public abstract double CalculateFuelConsumption();
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
        Console.WriteLine($"Грузовик: {name}");
        Console.WriteLine($"Грузоподъемность: {carryingCapacity} тонн");
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
        Console.WriteLine($"Легковой автомобиль: {name}");
        Console.WriteLine($"Объем двигателя: {engineVolume} см^3");
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
        double totalFuelConsumption = 0;
        foreach (Car car in cars)
        {
            car.DisplayInfo();
            double fuelConsumption = car.CalculateFuelConsumption();
            Console.WriteLine($"Расход горючего: {fuelConsumption} литров на 100 км");
            Console.WriteLine();
            totalFuelConsumption += fuelConsumption;
        }

        Console.WriteLine($"Общий расход горючего для всех автомобилей: {totalFuelConsumption} литров на 100 км");
    }
}