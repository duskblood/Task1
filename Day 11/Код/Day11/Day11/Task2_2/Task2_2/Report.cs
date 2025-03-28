using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Report
    {
        public StringBuilder Content { get; private set; } = new StringBuilder();

        public void AddSection(string section)
        {
            Content.AppendLine(section);
        }

        public void ShowReport()
        {
            Console.WriteLine(Content.ToString());
        }
    }
}
