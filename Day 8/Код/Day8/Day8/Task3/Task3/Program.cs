using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration();

            Console.Write("Введите ваш возраст для регистрации: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                try
                {
                    registration.RegisterUser(age);
                }
                catch (AgeRestrictionException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
            }
        }
    }
}
