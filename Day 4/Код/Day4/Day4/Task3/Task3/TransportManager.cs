using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
     class TransportManager
    {
        private Transport[] vehicles;

        public TransportManager(Transport[] vehicles)
        {
            this.vehicles = vehicles;
        }

        
        public Transport GetMostEfficientVehicle()
        {
            Transport mostEfficient = vehicles[0];

            foreach (var vehicle in vehicles)
            {
                if (vehicle.FuelConsumption < mostEfficient.FuelConsumption)
                {
                    mostEfficient = vehicle;
                }
            }

            return mostEfficient;
        }

        public Transport GetFastestVehicle()
        {
            Transport fastest = vehicles[0];

            foreach (var vehicle in vehicles)
            {
                if (vehicle.MaxSpeed > fastest.MaxSpeed)
                {
                    fastest = vehicle;
                }
            }

            return fastest;
        }
    }
}
