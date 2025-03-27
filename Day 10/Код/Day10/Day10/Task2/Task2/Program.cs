using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
        {
            new User("Иван", 25, "ivan@example.com"),
            new User("Ольга", 30, "olga@example.com"),
            new User("Петр", 22, "petr@example.com")
        };

            UserFileWriter userFileWriter = new UserFileWriter("file.data");
            userFileWriter.WriteUsers(users);

            Console.WriteLine("Данные пользователей успешно записаны в файл file.data.");
        }
    }
    
}
