using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            string input = Console.ReadLine();

            int maxDigit = 0;
            int minDigit = 9;

            foreach (char digitChar in input)
            {
                int digit = (int)(digitChar - '0'); 

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
            }

            Console.WriteLine($"Наибольшая цифра: {maxDigit}");
            Console.WriteLine($"Наименьшая цифра: {minDigit}");
        }
    }
}
