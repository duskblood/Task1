using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Целые числа от 1 до 101 (нечетные) с использованием цикла while:");
            PrintOddNumbersWhile();

            Console.WriteLine("\nЦелые числа от 1 до 101 (нечетные) с использованием цикла do while:");
            PrintOddNumbersDoWhile();

            Console.WriteLine("\nЦелые числа от 1 до 101 (нечетные) с использованием цикла for:");
            PrintOddNumbersFor();
        }

        static void PrintOddNumbersWhile()
        {
            int i = 1;
            while (i <= 101)
            {
                Console.Write(i + " ");
                i += 2; 
            }
            Console.WriteLine();
        }

        static void PrintOddNumbersDoWhile()
        {
            int i = 1;
            do
            {
                Console.Write(i + " ");
                i += 2; 
            } while (i <= 101);
            Console.WriteLine();
        }

        static void PrintOddNumbersFor()
        {
            for (int i = 1; i <= 101; i += 2) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    
    }
}
