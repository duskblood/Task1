using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите радиус круга ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга: {areaCircle:F2} кв.см");

          
            Console.Write("Введите длину прямоугольника  ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника ");
            double width = Convert.ToDouble(Console.ReadLine());
            double areaRectangle = length * width;
            Console.WriteLine($"Площадь прямоугольника: {areaRectangle:F2} кв.см");
        }
    }
}
