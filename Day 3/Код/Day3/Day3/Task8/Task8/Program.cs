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
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            string processedInput = input.Replace(" ", "").ToLower();

            
            bool isPalindrome = true;
            int length = processedInput.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (processedInput[i] != processedInput[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

        
            if (isPalindrome)
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом.");
            }
        }
    }
}
