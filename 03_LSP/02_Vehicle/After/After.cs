using System;

public class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Vehicle is driving...");
    }
}

public class VehiclesWithEngine : Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Starting Engine...");
    }
}

public class Car : VehiclesWithEngine
{
    public override void Drive()
    {
        Console.WriteLine("Car is driving...");
    }

    public override void StartEngine()
    {
        Console.WriteLine("Care is starting the engine...");
    }
}

public class Bicycle : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Bicycle is driving...");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();

        car.Drive(); // Output: care is driving
        car.StartEngine(); // Output: Care is starting the engine...


        Bicycle bicycle = new Bicycle();

        bicycle.Drive(); // Bicycle is driving...
    }
}
