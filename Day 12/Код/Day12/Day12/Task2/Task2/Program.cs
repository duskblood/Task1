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
            IPizza pizza = new BasicPizza();
            Console.WriteLine($"{pizza.GetDescription()} - {pizza.GetCost()}$");

            pizza = new CheeseDecorator(pizza);
            Console.WriteLine($"{pizza.GetDescription()} - {pizza.GetCost()}$");

            pizza = new PepperoniDecorator(pizza);
            Console.WriteLine($"{pizza.GetDescription()} - {pizza.GetCost()}$");

            pizza = new VeggieDecorator(pizza);
            Console.WriteLine($"{pizza.GetDescription()} - {pizza.GetCost()}$");
        }
    }
}
