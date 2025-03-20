using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Transport
    {
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public double FuelConsumption { get; set; } 

        protected Transport(string model, double maxSpeed, double fuelConsumption)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
        }
    }
}
