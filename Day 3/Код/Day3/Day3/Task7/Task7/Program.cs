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
            Console.WriteLine("Введите первую строку:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            string secondString = Console.ReadLine();

            string concatenatedString = string.Concat(firstString, secondString);

            Console.WriteLine("Результат соединения строк:");
            Console.WriteLine(concatenatedString);
        }
    }
}
