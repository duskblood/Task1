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
            
                Console.Write("Введите целое число K (1 <= K <= 100): ");
                int K = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите целое число N (1 <= N <= 100): ");
                int N = Convert.ToInt32(Console.ReadLine());

                if (K < 1 || K > 100 || N < 1 || N > 100)
                {
                    Console.WriteLine("Ошибка: K и N должны быть в диапазоне от 1 до 100.");
                    return;
                }

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(K);
                }
            
          
        }
    }
}
