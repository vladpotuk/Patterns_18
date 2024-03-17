using System;

public class VehicleReportVisitor : IVisitor
{
    public void VisitCar(Car car)
    {
        Console.WriteLine($"Car: Model={car.Model}, Year={car.Year}");
    }

    public void VisitMotorcycle(Motorcycle motorcycle)
    {
        Console.WriteLine($"Motorcycle: Model={motorcycle.Model}, Year={motorcycle.Year}");
    }
}
