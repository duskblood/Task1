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
          
            int[] numbers = new int[100];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }

            Console.WriteLine("Массив в обратном порядке:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
                if ((numbers.Length - 1 - i) % 6 == 5) 
                {
                    Console.WriteLine();
                }
            }

    
            Array.Sort(numbers);

            Console.WriteLine("\nВведите число для бинарного поиска:");
            int k = Convert.ToInt32(Console.ReadLine());

   
            int index = Array.BinarySearch(numbers, k);
            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено на индексе {index}.");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено.");
            }
        }
    }
}
