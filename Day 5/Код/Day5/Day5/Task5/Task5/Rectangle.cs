using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Прямоугольник с шириной: {Width} и высотой: {Height}");
        }
    }
}
