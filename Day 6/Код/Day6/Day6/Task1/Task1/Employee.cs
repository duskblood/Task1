using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract decimal CalculateSalary();
    }
}
