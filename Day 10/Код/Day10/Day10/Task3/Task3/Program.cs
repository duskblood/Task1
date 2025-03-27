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
            UserFileReader userFileReader = new UserFileReader("file.data");
            List<User> users = userFileReader.ReadUsers();

            if (users.Count == 0)
            {
                Console.WriteLine("Пользователи не найдены.");
                return;
            }

            UserProcessor userProcessor = new UserProcessor(users);

            
            Console.WriteLine("Введите email для поиска:");
            string emailToFind = Console.ReadLine();
            User foundUser = userProcessor.FindUserByEmail(emailToFind);

            if (foundUser != null)
            {
                Console.WriteLine($"Найден пользователь: {foundUser.Name}, Возраст: {foundUser.Age}, Email: {foundUser.Email}");
            }
            else
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }
    }
}
