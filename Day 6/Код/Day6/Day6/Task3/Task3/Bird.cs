using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Bird : Animal,ICanFly
    {
        public Bird(string name)
        {
            Name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} летит.");
        }

    }
}
