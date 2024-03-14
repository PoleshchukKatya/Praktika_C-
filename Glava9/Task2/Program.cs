using System;
using System.Linq;

interface IComparable<T>
{
    int CompareTo(T other);
}

class Car : IComparable<Car>
{
    public string LicensePlate { get; set; }
    public string Color { get; set; }
    public string OwnerName { get; set; }
    public bool IsPresent { get; set; }

    public int CompareTo(Car other)
    {
        return LicensePlate.CompareTo(other.LicensePlate);
    }
}

class ParkingLot
{
    private Car[] cars;

    public ParkingLot(int capacity)
    {
        cars = new Car[capacity];
    }

    public void AddCar(Car car, int spot)
    {
        cars[spot] = car;
    }

    public Car FindCarByLicensePlate(string licensePlate)
    {
        foreach (Car car in cars)
        {
            if (car != null && car.LicensePlate == licensePlate)
            {
                return car;
            }
        }
        return null;
    }

    public Car[] FindCarsByOwner(string ownerName)
    {
        return cars.Where(car => car != null && car.OwnerName == ownerName).ToArray();
    }

    public void PrintPresentCars()
    {
        Console.WriteLine("Присутствующие на стоянке автомобили:");
        foreach (Car car in cars)
        {
            if (car != null && car.IsPresent)
            {
                Console.WriteLine($"Госномер: {car.LicensePlate}, Цвет: {car.Color}, Владелец: {car.OwnerName}");
            }
        }
    }

    public void PrintAbsentCars()
    {
        Console.WriteLine("Отсутствующие на стоянке автомобили:");
        foreach (Car car in cars)
        {
            if (car != null && !car.IsPresent)
            {
                Console.WriteLine($"Госномер: {car.LicensePlate}, Цвет: {car.Color}, Владелец: {car.OwnerName}");
            }
        }
    }

    public Car GetCarInfoBySpot(int spot)
    {
        return cars[spot];
    }
}
class Program
{
    static void Main(string[] args)
    {
        ParkingLot parkingLot = new ParkingLot(10);

        parkingLot.AddCar(new Car { LicensePlate = "A123BC", Color = "Red", OwnerName = "Иванов", IsPresent = true }, 0);
        parkingLot.AddCar(new Car { LicensePlate = "B456DE", Color = "Blue", OwnerName = "Петров", IsPresent = true }, 1);
        parkingLot.AddCar(new Car { LicensePlate = "C789FG", Color = "Green", OwnerName = "Сидоров", IsPresent = false }, 2);

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Найти автомобиль по госномеру");
            Console.WriteLine("2. Найти автомобили по владельцу");
            Console.WriteLine("3. Вывести список присутствующих на стоянке автомобилей");
            Console.WriteLine("4. Вывести список отсутствующих на стоянке автомобилей");
            Console.WriteLine("5. Получить информацию по номеру места");
            Console.WriteLine("6. Выйти");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Пожалуйста, введите числовой вариант.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите госномер для поиска:");
                    string inputLicensePlate = Console.ReadLine();
                    Car foundCar = parkingLot.FindCarByLicensePlate(inputLicensePlate);
                    if (foundCar != null)
                    {
                        Console.WriteLine($"Найден автомобиль: Госномер: {foundCar.LicensePlate}, Цвет: {foundCar.Color}, Владелец: {foundCar.OwnerName}");
                    }
                    else
                    {
                        Console.WriteLine("Автомобиль с таким госномером не найден.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите фамилию владельца для поиска:");
                    string inputOwnerName = Console.ReadLine();
                    Car[] carsByOwner = parkingLot.FindCarsByOwner(inputOwnerName);
                    if (carsByOwner.Length > 0)
                    {
                        Console.WriteLine($"Найдены автомобили владельца {inputOwnerName}:");
                        foreach (Car car in carsByOwner)
                        {
                            Console.WriteLine($"Госномер: {car.LicensePlate}, Цвет: {car.Color}, Владелец: {car.OwnerName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Автомобили владельца {inputOwnerName} не найдены.");
                    }
                    break;
                case 3:
                    parkingLot.PrintPresentCars();
                    break;
                case 4:
                    parkingLot.PrintAbsentCars();
                    break;
                case 5:
                    Console.WriteLine("Введите номер места:");
                    if (int.TryParse(Console.ReadLine(), out int spotNumber))
                    {
                        if (spotNumber >= 0 && spotNumber < 10)
                        {
                            Car carInfo = parkingLot.GetCarInfoBySpot(spotNumber);
                            if (carInfo != null)
                            {
                                Console.WriteLine($"Информация по месту {spotNumber}: Госномер: {carInfo.LicensePlate}, Цвет: {carInfo.Color}, Владелец: {carInfo.OwnerName}");
                            }
                            else
                            {
                                Console.WriteLine($"На месте {spotNumber} нет автомобиля.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неправильный номер места. Допустимые значения от 0 до 9.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправильный формат номера места.");
                    }
                    break;
                case 6:
                    Console.WriteLine("Программа завершена.");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие из списка.");
                    break;
            }
        }
    }
}