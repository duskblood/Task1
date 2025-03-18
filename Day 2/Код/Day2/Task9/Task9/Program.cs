using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = Math.PI / 2;
            int M = 10;
            double H = (B - A) / M;

            Console.WriteLine(" xi        F(xi)");
            Console.WriteLine("--------------------");
            for (int i = 0; i <= M; i++)
            {
                double xi = A + i * H;
                double Fxi = Function(xi); 
                Console.WriteLine($"{xi:F4}\t {Fxi:F4}");
            }
        }

        static double Function(double x)
        {
            return x - Math.Sin(x);
        }
    
    }
}
