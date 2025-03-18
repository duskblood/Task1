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
            Console.Write("Введите дистанцию в сантиметрах :");
            int distanceCm = int.Parse(Console.ReadLine()); 
            int fullMeters = ConvertToFullMeters(distanceCm);
            Console.WriteLine($"Полные метры: {fullMeters}");
            
        }
        static int ConvertToFullMeters(int centimeters)
        {
            return centimeters / 100; 
        }
    }
}
