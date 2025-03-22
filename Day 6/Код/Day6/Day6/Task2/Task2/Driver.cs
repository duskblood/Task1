using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Driver
    {
        public string Name { get; set; }

        public Driver(string name)
        {
            Name = name;
        }

        public void Drive(Car car)
        {
            Console.WriteLine($"{Name} Едет на  {car.GetCarDescription()}");
        }
    }
}
