using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 1, 8, 4, 2, 9, 0, 7, 6, 11, 10, 14, 13, 12 };


            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);

            int maxIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex != 0)
            {
                int temp = numbers[0];
                numbers[0] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }

            Console.WriteLine("Измененный массив:");
            PrintArray(numbers);
        }

        static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    
    }
}
