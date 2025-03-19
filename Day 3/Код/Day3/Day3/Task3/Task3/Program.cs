using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы N (N < 10):");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N >= 10)
            {
                Console.WriteLine("Ошибка: N должно быть меньше 10.");
                return;
            }

            Console.WriteLine("Введите диапазон a и b (a < b):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[N, N];
            Random random = new Random();
            int positiveCount = 0;

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(a, b + 1); 
                    Console.Write(matrix[i, j] + "\t");

                    if (matrix[i, j] > 0)
                    {
                        positiveCount++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма элементов каждой строки:");
            for (int i = 0; i < N; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < N; j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine($"Сумма строки {i + 1}: {rowSum}");
            }

            Console.WriteLine($"\nКоличество положительных чисел: {positiveCount}");

        }
    }
}
