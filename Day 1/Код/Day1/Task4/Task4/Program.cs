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
            Console.Write("Введите первое целое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

         
            Console.Write("Введите второе целое число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;


            Console.WriteLine($"Сумма {firstNumber} + {secondNumber} = {sum}");
        }
    }
}
