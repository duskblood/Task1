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
                Console.Write("Введите коэффициент A: ");
                double A = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите коэффициент B: ");
                double B = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите коэффициент C: ");
                double C = Convert.ToDouble(Console.ReadLine());

                bool hasRealRoots = CheckForRealRoots(A, B, C);
                Console.WriteLine($"Квадратное уравнение имеет вещественные корни: {hasRealRoots}");
        }

        static bool CheckForRealRoots(double A, double B, double C)
        {
            if (A == 0)
            {
                throw new ArgumentException("Коэффициент A не должен быть равен нулю.");
            }

            double discriminant = B * B - 4 * A * C;
            return discriminant >= 0;
        }
    }
}
