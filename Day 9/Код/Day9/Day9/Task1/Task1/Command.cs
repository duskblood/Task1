using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Command
    {
        public string Description { get; private set; }

        public Command(string description)
        {
            Description = description;
        }

        public void Execute()
        {
            Console.WriteLine($"Проведение: {Description}");
        }

        public void Undo()
        {
            Console.WriteLine($"Уничтожающий: {Description}");
        }
    }

}
