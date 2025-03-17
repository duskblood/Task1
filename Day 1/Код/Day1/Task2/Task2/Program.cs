using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 10 && number <= 99)
            {
                int firstDigit = number / 10; 
                int lastDigit = number % 10;   

                Console.WriteLine($"Первая цифра: {firstDigit}");
                Console.WriteLine($"Последняя цифра: {lastDigit}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите двузначное число.");
            }
        }
    }
}
