using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк (N) для ступенчатого массива:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[][] stepArray = new int[N][];

            for (int i = 0; i < N; i++)
            {
                stepArray[i] = new int[i + 1];

                int sum = 0;

                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    
                    sum += (j + 1); 
                    stepArray[i][j] = sum;
                }
            }
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < stepArray[i].Length; j++)
                {
                    Console.Write(stepArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    
    }
}
