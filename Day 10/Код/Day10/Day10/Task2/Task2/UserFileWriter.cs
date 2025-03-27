using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class UserFileWriter
    {
        private string filePath;

        public UserFileWriter(string path)
        {
            filePath = path;
        }

        public void WriteUsers(List<User> users)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var user in users)
                {
                    writer.WriteLine($"{user.Name},{user.Age},{user.Email}");
                }
            }
        }
    }
}
