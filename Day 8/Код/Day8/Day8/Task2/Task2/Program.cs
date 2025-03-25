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
            FileProcessor processor = new FileProcessor();
            string filePath = "nonexistentfile.txt"; 

            try
            {
                processor.ProcessFile(filePath);
            }
            catch (CustomFileException ex)
            {
                
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                Console.WriteLine("Внутреннее исключение: " + ex.InnerException.Message);
                Console.WriteLine("Стек вызовов: " + ex.StackTrace);
            }
        }
    }
}
