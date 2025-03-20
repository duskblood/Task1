using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    

    public partial class Student
    {
        public static List<Student> GetTopStudents(Student[] students)
        {
            return students.Where(s => s.GPA > 4.5).ToList();
        }

        public static List<Student> GetStudentsByGroup(Student[] students, string group)
        {
            return students.Where(s => s.Group.Equals(group, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
