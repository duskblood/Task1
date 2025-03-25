using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class UserAgeValidator
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Некорректный возраст: " + age);
            }
            Console.WriteLine("Возраст принят: " + age);
        }
    }
}
