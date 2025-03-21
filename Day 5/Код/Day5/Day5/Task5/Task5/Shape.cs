using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
   abstract public class Shape
    {
        public abstract double CalculateArea();

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Это фигура.");
        }
    }
}
