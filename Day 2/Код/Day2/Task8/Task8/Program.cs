using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;


            Console.Write("Введите целое число N (1 <= N <= 10): ");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > 10)
            {
                Console.WriteLine("Ошибка: Пожалуйста, целое число в диапазоне от 1 до 10.");
            }

            int sum = CalculateSum(N);

            Console.WriteLine($"Сумма: {sum}");
        }

        static int CalculateSum(int N)
        {
            int sum = 0;
            for (int i = N; i <= 2 * N; i++)
            {
                sum += i * i; 
            }
            return sum;
        }
    
    }
}
