using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        public static void PowerA3(double A, out double B)
        {
            B = A * A * A; 
        }
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            double result;

            Console.WriteLine("Введите 5 вещественных чисел:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nТретьи степени введенных чисел:");
            for (int i = 0; i < 5; i++)
            {
                PowerA3(numbers[i], out result);
                Console.WriteLine($"Третья степень числа {numbers[i]} равна {result}");
            }
        }
    }
}
