using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            circle.DisplayInfo();
            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}\n");
            rectangle.DisplayInfo();
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
        }
    }
}
