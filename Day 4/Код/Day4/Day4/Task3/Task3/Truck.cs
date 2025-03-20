using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    sealed class Truck : Transport
    {
        public Truck(string model, double maxSpeed, double fuelConsumption) : base(model, maxSpeed, fuelConsumption)
        {

        }

    }
}
