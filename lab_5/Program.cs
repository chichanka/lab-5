using System;
using System.Collections.Generic;

// Абстрактний клас транспортних засобів
abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Клас людини
class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is moving.");
    }
}

// Спадкоємці класу Vehicle: Car, Bus, Train
class Car : Vehicle
{
    public Car()
    {
        Speed = 60;
        Capacity = 5;
    }

    public override void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}

class Bus : Vehicle
{
    public Bus()
    {
        Speed = 40;
        Capacity = 20;
    }

    public override void Move()
    {
        Console.WriteLine("Bus is moving.");
    }
}

class Train : Vehicle
{
    public Train()
    {
        Speed = 80;
        Capacity = 100;
    }

    public override void Move()
    {
        Console.WriteLine("Train is moving.");
    }
}

// Клас мережі транспорту
class TransportNetwork
{
    private List<Vehicle> vehicles;

    public TransportNetwork()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ControlMovement()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}

// Клас маршруту
class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public Route(string startPoint, string endPoint)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
    }

    public string CalculateOptimalRoute(string vehicleType)
    {
        // Реалізація розрахунку оптимального маршруту для конкретного типу транспорту
        return $"Optimal route for {vehicleType} from {StartPoint} to {EndPoint}.";
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();
        // Додавання транспортних засобів до мережі
        TransportNetwork transportNetwork = new TransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);
        // Контроль руху транспорту
        transportNetwork.ControlMovement();
        // Створення маршруту
        Route route = new Route("City A", "City B");
        // Розрахунок оптимального маршруту для конкретного транспорту
        string carRoute = route.CalculateOptimalRoute("Car");
        string busRoute = route.CalculateOptimalRoute("Bus");
        string trainRoute = route.CalculateOptimalRoute("Train");
        // Виведення результатів
        Console.WriteLine(carRoute);
        Console.WriteLine(busRoute);
        Console.WriteLine(trainRoute);
    }
}

