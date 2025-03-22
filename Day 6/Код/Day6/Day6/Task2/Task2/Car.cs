using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Car
    {
        public Wheel[] Wheels { get; set; }
        public Engine Engine { get; private set; }
        public string Model { get; set; }

        public Car(string model, Engine engine, Wheel[] wheels)
        {
            Model = model;
            Engine = engine; 
            Wheels = wheels; 
        }

        public string GetCarDescription()
        {
            return $"{Model} с {Engine.Type} Мотором и  {Wheels.Length} колесами";
        }
    }
}
