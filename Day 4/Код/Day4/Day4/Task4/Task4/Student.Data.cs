using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public partial class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public double GPA { get; set; }

        public Student(string name, string group, double gpa)
        {
            Name = name;
            Group = group;
            GPA = gpa;
        }
    }
}
