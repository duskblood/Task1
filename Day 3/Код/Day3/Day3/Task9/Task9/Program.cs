using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Введите строку для добавления в StringBuilder:");
            string inputString = Console.ReadLine();

            sb.Append(inputString);

            Console.WriteLine("Введите строку, которую нужно добавить в начало:");
            string prependString = Console.ReadLine();

            sb.Insert(0, prependString);

            Console.WriteLine("Результат после добавления:");
            Console.WriteLine(sb.ToString());

            bool isAllDigits = true;

            foreach (char c in sb.ToString())
            {
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c)) 
                {
                    isAllDigits = false;
                    break;
                }
            }

            if (isAllDigits)
            {
                Console.WriteLine("Строка содержит только цифры.");
            }
            else
            {
                Console.WriteLine("Строка содержит не только цифры.");
            }
        }
    }
}
