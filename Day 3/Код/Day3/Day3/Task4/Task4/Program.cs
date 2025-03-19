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
            Console.WriteLine("Введите количество строк (N):");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов (M):");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, cols];
            Random random = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 101);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int product = 1;
            for (int i = 0; i < rows; i++)
            {
                product *= array[i, 1];
            }

            if (product >= 100 && product <= 999)
            {
                Console.WriteLine($"\nПроизведение элементов второго столбца: {product} - является трехзначным числом.");
            }
            else
            {
                Console.WriteLine($"\nПроизведение элементов второго столбца: {product} - не является трехзначным числом.");
            }
        
    }
    }
}
