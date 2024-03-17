using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { Model = "Toyota Camry", Year = 2019 },
            new Motorcycle { Model = "Honda CBR500R", Year = 2020 }
        };

        var reportVisitor = new VehicleReportVisitor();
        foreach (var vehicle in vehicles)
        {
            vehicle.Accept(reportVisitor);
        }
    }
}
