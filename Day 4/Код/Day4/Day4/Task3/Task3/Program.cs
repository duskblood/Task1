using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport[] vehicles = new Transport[]
            {
            new Car("Toyota Camry", 210, 8.5),
            new Truck("Volvo FH", 120, 30),
            new Car("Honda Accord", 220, 7.5),
            new Truck("MAN TGS", 140, 28)
       };

          
            TransportManager manager = new TransportManager(vehicles);

            
            Transport efficientVehicle = manager.GetMostEfficientVehicle();
            Console.WriteLine($"Самый эффективный транспорт: {efficientVehicle.Model}, Расход топлива: {efficientVehicle.FuelConsumption} л/100 км");

       
            Transport fastestVehicle = manager.GetFastestVehicle();
            Console.WriteLine($"Самый быстрый транспорт: {fastestVehicle.Model}, Максимальная скорость: {fastestVehicle.MaxSpeed} км/ч");
        }
    }
    
}
