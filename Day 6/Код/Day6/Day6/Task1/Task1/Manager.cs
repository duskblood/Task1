using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
     class Manager : Employee
    {
        public decimal BaseSalary { get; set; }

        public Manager(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public override decimal CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.2m);
        }
    }
}
