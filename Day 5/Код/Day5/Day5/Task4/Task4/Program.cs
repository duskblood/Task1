using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class Program
    {
        public static int CountVowels(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int count = 0;

            char[] vowels =
       {
            'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', 
            'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 
            'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я'  
        };


            foreach (char c in str)
            {
                if (Array.Exists(vowels, v => v == c))
                {
                    count++; 
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int vowelCount = input.CountVowels();
            Console.WriteLine($"Количество гласных букв: {vowelCount}");
        }
    }
}
