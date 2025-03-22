using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
      {
            new Bird("воробей"),
            new Fish("золотая рыбка"),
            new Bird("стриж"),
            new Fish("акула")
      };

            var flyingAnimals = animals.OfType<ICanFly>();

            Console.WriteLine("животные умееющие летать:");
            foreach (var animal in flyingAnimals)
            {
                var bird = animal as Bird;
                bird?.Fly();
            }
        }
    }
}
