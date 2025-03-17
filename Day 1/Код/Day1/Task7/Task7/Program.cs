using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите координаты первой точки M1 (x1, y1): ");
            string[] input1 = Console.ReadLine().Split(',');
            double x1 = Convert.ToDouble(input1[0]);
            double y1 = Convert.ToDouble(input1[1]);

           
            Console.Write("Введите координаты второй точки M2 (x2, y2): ");
            string[] input2 = Console.ReadLine().Split(',');
            double x2 = Convert.ToDouble(input2[0]);
            double y2 = Convert.ToDouble(input2[1]);

           
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

         
            Console.WriteLine($"Расстояние между точками M1 и M2: d = {distance}");
        }
    }
}
