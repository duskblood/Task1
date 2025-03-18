using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите значение X: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double y;

                if (x < 1)
                {
                    y = 1;
                }
                else if (x >= 1 && x < 2)
                {
                    y = x * x * Math.Log(x);
                }
                else 
                {
                    y = Math.Exp(2 * x) * Math.Cos(5 * x);
                }

                Console.WriteLine($"Значение Y: {y}");
        }
    }
}
