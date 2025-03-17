using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x:");
            double x = int.Parse(Console.ReadLine());

            
            double logPart = Math.Log(Math.Abs(3 - x * x));
            double arctanPart = Math.Atan(x) * x;
            double expPart = Math.Exp(Math.Sin(x) * Math.Sqrt(x));

            if (arctanPart != 0)
            {
              
                double result = (1 + logPart) / arctanPart - expPart;
                Console.WriteLine($"Значение функции при x = {x}: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
            }
        }
    }
}
