using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class WordReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Генерация Word отчета.");
        }
    }
}
