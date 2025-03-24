using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate string StringProcessor(string input);
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "Привет Мир!";


            string upperResult = ProcessString(testString, ToUpperCase);
            Console.WriteLine($"Верхний регистр: {upperResult}");


            string lowerResult = ProcessString(testString, ToLowerCase);
            Console.WriteLine($"Нижний регистр: {lowerResult}");
        }


        public static string ProcessString(string input, StringProcessor processor)
        {
            return processor(input);
        }
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }
        public static string ToLowerCase(string input)
        {
            return input.ToLower();
        }
    }
}
