using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class University
    {
        private Student[] students;

        public University(Student[] students)
        {
            this.students = students;
        }
        public List<Student> GetTopStudents()
        {
            return Student.GetTopStudents(students);
        }

        public List<Student> GetStudentsByGroup(string group)
        {
            return Student.GetStudentsByGroup(students, group);
        }
    }
}
