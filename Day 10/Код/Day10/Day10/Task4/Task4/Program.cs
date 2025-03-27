using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\TestDirectory"; 

            try
            {
                FileWatcher fileWatcher = new FileWatcher(path);
                Console.WriteLine($"Начато отслеживание изменений в директории: {path}");
                Console.WriteLine("Нажмите 'Enter' для выхода.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

    }
}
