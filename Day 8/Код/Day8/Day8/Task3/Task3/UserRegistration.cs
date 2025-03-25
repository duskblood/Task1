using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class UserRegistration
    {
        public void RegisterUser(int age)
        {
            
            if (age < 18)
            {
                throw new AgeRestrictionException("Некорректный возраст: " + age);
            }

            Console.WriteLine("Пользователь успешно зарегистрирован.");
        }
    }
}
