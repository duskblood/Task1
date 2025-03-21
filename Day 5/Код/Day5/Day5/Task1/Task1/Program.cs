using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала:");
            int number = int.Parse(Console.ReadLine());
            long factorial = FactorialCalculator.Factorial(number);
            Console.WriteLine($"Факториал {number} равен {factorial}");
        }
    }
}
