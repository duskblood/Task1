using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = Math.Pow(Math.Cos(x), 2) - (Math.Sqrt(x * x * x) + 1) / Math.Sin(x) + Math.Exp(Math.Log(2 * x));


            Console.WriteLine($"Значение функции при x = {x}: y = {y}");
        }
    }
}
