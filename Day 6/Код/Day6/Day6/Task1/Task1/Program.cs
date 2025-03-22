using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
       {
            new Manager("Катя", 5000),
            new Developer("Петя", 4000),
            new Intern("Вася", 15, 160)
       };

            Console.WriteLine("Список сотрудников и их зарплаты:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}: {employee.CalculateSalary():C}");
            }
        }
    }
}
