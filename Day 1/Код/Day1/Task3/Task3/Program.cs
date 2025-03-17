using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            
            double z1 = (Math.Sin(Math.PI / 2 + 3 * a)) / (1 - Math.Sin(3 * a - Math.PI));

            
            double z2 = 1 / Math.Tan(5.0 / 4 * Math.PI + 3.0 / 2 * a); 

      
            Console.WriteLine($"При a = {a}:");
            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");
            if (Math.Abs(z1 - z2) < 0.0001)
            {
                Console.WriteLine("Результаты совпадают.");
            }
            else
            {
                Console.WriteLine("Результаты не совпадают.");
            }
        }
    }
}
