using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class UserFileReader
    {
        private string filePath;

        public UserFileReader(string path)
        {
            filePath = path;
        }

        public List<User> ReadUsers()
        {
            List<User> users = new List<User>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string name = parts[0];
                            int age = int.Parse(parts[1]);
                            string email = parts[2];
                            users.Add(new User(name, age, email));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return users;
        }

    }
}
