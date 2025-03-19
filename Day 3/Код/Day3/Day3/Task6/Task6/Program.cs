using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int vowelCount = 0;
            int consonantCount = 0;

            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯaeiouyAEIOUY";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine($"Количество гласных: {vowelCount}");
            Console.WriteLine($"Количество согласных: {consonantCount}");
        }
    
    }
}
