using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
       {
            new Student("Антон", "39тп", 4.6),
            new Student("Олег", "41тп", 3.9),
            new Student("Паша", "27тп", 4.8),
            new Student("Инокентий", "40тп", 4.3)
       };

            
            University university = new University(students);

           
            List<Student> topStudents = university.GetTopStudents();
            Console.WriteLine("Студенты  выше 4.5:");
            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.GPA}");
            }
            string groupToSearch = "41тп";
            List<Student> studentsInGroup = university.GetStudentsByGroup(groupToSearch);
            Console.WriteLine($"\nСтуденты группы {groupToSearch}:");
            foreach (var student in studentsInGroup)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
    
}
