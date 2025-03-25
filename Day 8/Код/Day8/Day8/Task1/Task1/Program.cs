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

            UserAgeValidator validator = new UserAgeValidator();

            Console.Write("Введите ваш возраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                try
                {
                    validator.ValidateAge(age);
                }
                catch (InvalidAgeException ex)
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
