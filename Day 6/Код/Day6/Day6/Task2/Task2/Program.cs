using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wheel[] wheels1 = { new Wheel(16), new Wheel(16), new Wheel(16), new Wheel(16) };
            Car car1 = new Car("Mazda 6", new Engine("V4"), wheels1);

            Wheel[] wheels2 = { new Wheel(17), new Wheel(17), new Wheel(17), new Wheel(17) };
            Car car2 = new Car("Mitsubisi Gallant", new Engine("V6"), wheels2);

            Driver driver = new Driver("Сергей");

            Car[] cars = { car1, car2 };

            Console.WriteLine("Машины:");
            foreach (var car in cars)
            {
                driver.Drive(car);
            }
        }
    }
}
