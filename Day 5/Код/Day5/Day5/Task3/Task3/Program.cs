using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        public static long Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

           
            return number * Factorial(number - 1);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала:");
            int number = int.Parse(Console.ReadLine());
            long factorial = Factorial(number);
            Console.WriteLine($"Факториал {number} равен {factorial}");
            
            
        }
    }
}
