using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Fish : Animal, ICanSwim
    {
        public Fish(string name)
        {
            Name = name;
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} плавает.");
        }
    }
}
