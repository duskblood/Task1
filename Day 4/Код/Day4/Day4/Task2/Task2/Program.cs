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
            Person[] people = new Person[]
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("Diana", 28)
        };
            int maxAge = ArrayUtils.GetMaxValue(people);

            Console.WriteLine($"Максимальный возраст: {maxAge}");
        }
    }
}
