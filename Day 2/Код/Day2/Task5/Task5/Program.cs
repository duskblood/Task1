using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                Console.Write("Введите первое вещественное число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе вещественное число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num1 == num2)
                {
                    Console.WriteLine("Числа должны быть различными.");
                    return;
                }

                double maxNum = (num1 > num2) ? num1 : num2;

                Console.WriteLine($"Максимальное значение: {maxNum}");
           
        }
    }
}
